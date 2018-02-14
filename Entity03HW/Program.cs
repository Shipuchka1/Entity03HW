using Entity03HW.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Entity03HW
{
    class Program
    {
        public static void SendMail(string text)
        {
            MailMessage msg = new MailMessage();

            msg.From = new MailAddress("v@gmail.com");
            msg.To.Add("Natalie1995@list.ru");
            msg.Subject = "Hello world! " + DateTime.Now.ToString();
            msg.Body = text;
            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = false;
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential("v@gmail.com", "password");
            client.Timeout = 10000;
            try
            {
                client.Send(msg);
                return;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                return;
            }
            finally
            {
                msg.Dispose();
            }
        }
        public static Model1 db = new Model1();
        static void Main(string[] args)
        {
            

        }
    }
}
