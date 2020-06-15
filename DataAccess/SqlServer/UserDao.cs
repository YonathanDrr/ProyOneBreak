using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;

namespace DataAccess.SqlServer
{
    public class UserDao : ConnectionToSql
    {
        //validar usuario o email y contraseña al iniciar sesion
        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from users where (loginName=@user and password=@pass) or (Email=@user and password=@pass)";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read()) //Obtenemos los datos de la columna y asignamos a los campos de usuario activo en cache
                        {
                            UserCache.IdUser = reader.GetInt32(0); //ID usuario esta en la columna 0 de la tabla Usuarios.
                            UserCache.LoginName = reader.GetString(1);//Nombre de inicio de sesion esta en la columna 1 de la tabla usuarios
                            UserCache.Password = reader.GetString(2);
                            UserCache.FirstName = reader.GetString(3); 
                            UserCache.LastName = reader.GetString(4);
                            UserCache.Position = reader.GetString(5);
                            UserCache.Email = reader.GetString(6);
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
        }

        //Registrar nuevo usuario
        public int register(string user, string pass, string name, string lastName, string position, string mail)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into users values( @user, @pass, @name, @lastname,@position, @mail)";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@position", position);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.CommandType = CommandType.Text;
                    return command.ExecuteNonQuery();
                }
            }
        }

        //Registrar nuevo cliente
        public int registerCli(string rutCliente, string razonSocial, string nombreCli, string email, string direccion, string telefono, string actividadEmp,string tipoEmp)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "insert into cliente values( @rutCliente, @razonSocial, @nombreContacto, @email,@direccion, @telefono ,@idactividadempresa,@idtipoempresa)";
                    command.Parameters.AddWithValue("@rutCliente", rutCliente);
                    command.Parameters.AddWithValue("@razonSocial", razonSocial);
                    command.Parameters.AddWithValue("@nombreContacto", nombreCli);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@idactividadempresa", actividadEmp);
                    command.Parameters.AddWithValue("@idtipoempresa", tipoEmp);
                    command.CommandType = CommandType.Text;
                    return command.ExecuteNonQuery();
                }
            }
        }

        //Editar perfil de usuario
        public int editProfile(int id, string user, string pass, string name, string lastName, string mail)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "update Users set LoginName=@user, Password=@pass, FirstName=@name, LastName=@lastname, Email=@mail where UserID=@id";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@mail", mail);
                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;
                    return command.ExecuteNonQuery();
                }
            }
        }

        //Solicitar recuperar contraseña del usuario a la base de datos.
        public string recoverPassword(string userRequesting)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Users where LoginName=@user or Email=@mail";
                    command.Parameters.AddWithValue("@user", userRequesting);
                    command.Parameters.AddWithValue("@mail", userRequesting);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(3) + ", " + reader.GetString(4);
                        string userMail = reader.GetString(6);
                        string accountPassword = reader.GetString(2);

                        var mailService = new MailServices.SystemSupportMail();
                        mailService.sendMail(
                            subject: "SISTEMA: Solicitudes de recuperación de contraseña",
                            body: "Hola, " + userName + "\nSolicitó recuperar su contraseña..\n" +
                            "tu contraseña actual es: " + accountPassword +
                            "\nSin embargo, le pedimos que cambie su contraseña inmediatamente una vez que ingrese al sistema",
                            recipientMail: new List<string> { userMail }
                            );
                        return "Hola, " + userName + "\nSolicite recuperar su contraseña.\n" +
                            "Por favor revise su correo: " + userMail +
                            "\nSin embargo, le pedimos que cambie su contraseña inmediatamente una vez que ingrese al sistema.";
                    }
                    else
                        return "Lo sentimos, no tienes una cuenta con ese correo o nombre de usuario";
                }
            }
        }

        //Seguridad principal de aplicacion para inicio de sesion
        public bool existsUser(int id, string loginName, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from users where userId=@id and loginName=@loginName and password=@pass";
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@loginName", loginName);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    var reader = command.ExecuteReader();
                    if (reader.HasRows)
                        return true;
                    else
                        return false;
                }
            }
        }
        
        public void AnyMethod()
        {
            if (UserCache.Position == Positions.Administrador)
            {
                //Codes
            }
            if (UserCache.Position == Positions.Recepcionista || UserCache.Position == Positions.Contabilidad)
            {
                //Codes
            }
        }
    }
}
