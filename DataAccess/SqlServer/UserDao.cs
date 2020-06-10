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
        //validate user or email and password when starting session.//validar usuario o email y contraseña al iniciar sesion
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
                        while (reader.Read()) //We obtain the data from the column and assign to the active user fields in cache./Obtenemos los datos de la columna y asignamos a los campos de usuario activo en cache
                        {
                            UserCache.IdUser = reader.GetInt32(0); //User ID is in column 0 of the Users table./ID usuario esta en la columna 0 de la tabla Usuarios.
                            UserCache.LoginName = reader.GetString(1);//Login name Is in column 1 of the users table./Nombre de inicio de sesion esta en la columna 1 de la tabla usuarios
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

        //Register new user. //Registrar nuevo usuario
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

        //Edit user profile.//Editar perfil de usuario
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

        //Request to recover the user's password to the database.//Solicitar recuperar contraseña del usuario a la base de datos.
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
                            subject: "SYSTEM: Password recovery request",
                            body: "Hi, " + userName + "\nYou Requested to Recover your password.\n" +
                            "your current password is: " + accountPassword +
                            "\nHowever, we ask that you change your password inmediately once you enter the system.",
                            recipientMail: new List<string> { userMail }
                            );
                        return "Hi, " + userName + "\nYou Requested to Recover your password.\n" +
                            "Please check your mail: " + userMail +
                            "\nHowever, we ask that you change your password inmediately once you enter the system.";
                    }
                    else
                        return "Sorry, you do not have an account with that mail or username";
                }
            }
        }

        //Main security of the application for start of session.//Seguridad principal de aplicacion para inicio de sesion
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
