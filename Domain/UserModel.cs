using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.SqlServer;
using Common.Cache;

namespace Domain
{
    public class UserModel
    {
        private UserDao userDao = new UserDao();

        // Attributos
        private int idUser;
        private string loginName;
        private string password;
        private string firstName;
        private string lastName;
        private string position;
        private string email;

      // Constructor con parámetros
        public UserModel(int idUser, string loginName, string password, string firstName, string lastName, string position, string email)
        {
            this.idUser = idUser;
            this.loginName = loginName;
            this.password = password;
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
            this.email = email;
        }

       // Constructor sin parámetros
        public UserModel()
        {
        }

        // Propiedades
      
        // Metodos
        //Registrar nuevo usuario
        public bool validUser = false;
        public string registerUser()
        {
            try
            {
                var result = userDao.register(loginName, password, firstName, lastName, position, email);
                if (result >= 1)
                {
                    Login(loginName, password);
                    validUser = true;
                    return "[ : ) ]  Su cuenta ha sido creada exitosamente, por favor inicie sesión";
                }
                else
                {
                    validUser = false;
                    return  "Ha ocurrido un error, inténtalo de nuevo o contacta con el administrador del sistema";
                }
            }
            catch (Exception ex)
            {
                validUser = false;
                return "[ : ( ]  Nombre de usuario ya está registrado, pruebe con otro"+ex;
            }
        }

        //Editar perfil de usuario
        public string editUserProfile()
        {
            try
            {
                var result = userDao.editProfile(idUser, loginName, password, firstName, lastName, email);
                if (result >= 1)
                {
                    Login(loginName, password); //Invocar nuevamente metodo login para actualizar el cache de usuario.
                    return "[ : ) ] Tú perfil ha sido actualizado satisfactoriamente";
                        
                }
                else
                    return "Ha ocurrido un error, inténtalo de nuevo o contacta con el administrador del sistema";
            }
            catch (Exception ex)
            {
                return "[ : ( ]  Nombre de usuario ya está registrado, pruebe con otro"+ex ;
            }
        }

     //validar usuario y contraseña al iniciar sesion
        public bool Login(string user, string pass)
        {
            bool result=false;
            try
            {
                result = userDao.Login(user, pass);
            }
            catch (Exception ex)
            {
                throw new System.ArgumentException("A ocurrido un error.\n"+ex);
            }
            return result;
        }

         //Solicitar recuperar contraseña del usuario a la base de datos.
        public string recoverPassword(string requestingUser)
        {
            try
            {
                return userDao.recoverPassword(requestingUser);
            }
            catch (Exception ex)
            {
                return  "Ha ocurrido un error, inténtalo de nuevo o contacta con el administrador del sistema\nDETAILS\n+"+ex;
            }
        }

         //Seguridad principal de aplicacion para inicio de sesion (Anti-Hacking)
        public bool securityLogin()
        {
            if (UserCache.IdUser >= 1)
            {
                if (userDao.existsUser(UserCache.IdUser, UserCache.LoginName, UserCache.Password) == true)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        // Seguridad en la posicion
        public void anyMethod()
        {
            if (UserCache.Position == Positions.Recepcionista)
            {
            }
            if (UserCache.Position == Positions.Contabilidad)
            {
            }
        }
    }
}
