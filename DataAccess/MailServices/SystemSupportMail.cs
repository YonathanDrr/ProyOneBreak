using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MailServices
{
    class SystemSupportMail:MasterMailServer 
    {
        public SystemSupportMail() {
            senderMail = "yonathan.anthony96@gmail.com";// ' agregar correo electronico
            password = "12345678";// contraseña
            host = "smtp.gmail.com"; // 'Nombre del servidor' 
            port = 587; //' puerto del servidor
            ssl = true;//' si tiene cifrado ssl o tsl
            initializeSmtpClient();// ' inicializamos el cliente protocolo de transferiencia de mensajes simples con los datos anteriores
        }
    }
}
