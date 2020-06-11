using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.SqlServer;
using Common.Cache;

namespace Domain
{
    public class UserClient
    {
        private UserDao userDao = new UserDao();

        // Attributos

       
        private string rutCliente;
        private string razonSocial;
        private string nombreCli;
        private string email;
        private string direccion;
        private string telefono;
        private string actividadEmp;
        private string tipoEmp;

        public UserClient( string rutCliente, string razonSocial, string nombreCli, string email, string direccion, string telefono, string actividadEmp, string tipoEmp)
        {


            this.rutCliente = rutCliente;
            this.razonSocial = razonSocial;
            this.nombreCli = nombreCli;
            this.email = email;
            this.direccion = direccion;
            this.telefono = telefono;
            this.actividadEmp = actividadEmp;
            this.tipoEmp = tipoEmp;
        }

        public UserClient()
        {
        }

        public bool validUser = false;

        public string registerCliente()
        {
            try
            {
                var result = userDao.registerCli(rutCliente, razonSocial, nombreCli, email, direccion, telefono, actividadEmp, tipoEmp);
                if (result >= 1)
                {

                    validUser = true;
                    return "[ : ) ]  Usuario creado exitosamente";
                }
                else
                {
                    validUser = false;
                    return "Ha ocurrido un error, inténtalo de nuevo o contacta con el administrador del sistema";
                }
            }
            catch (Exception ex)
            {
                validUser = false;
                return "[ : ( ]  error inesperado" + ex;
            }
        }


    }
}
