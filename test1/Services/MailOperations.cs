using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace test1.Services
{
    public class MailOperations
    {
        const string mailname = "kronosbetamail@gmail.com";
        const string password = "Emrekurt027";
        const string displayname = "Kronos Energy";

        public static async Task<bool> receivedMail(Models.MailModel model, string forwSub, string forwBody)
        {
            NetworkCredential senderInfo = new NetworkCredential(mailname, password);
            MailMessage mail = new MailMessage
            {
                From = new MailAddress(senderInfo.UserName, model.Name + " (" + model.Email + ")")
            };
            mail.To.Add(mailname);
            mail.Subject = model.Subject + " - " + model.Name;
            mail.Body = CreateBody(model);
            mail.IsBodyHtml = true;

            Attachment att = new Attachment(@"wwwroot\lib\images\mail\mailticket.png");
            mail.Attachments.Add(att);

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = senderInfo
            };


            try
            {
                await smtp.SendMailAsync(mail);
                sendMail(model.Email, forwSub, forwBody);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            return true;
        }
        public static async Task<bool> sendMail(string to, string subject, string body)
        {
            NetworkCredential senderInfo = new NetworkCredential(mailname, password);
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress(senderInfo.UserName, displayname);
            mail.To.Add(to);
            mail.Subject = subject;
            mail.IsBodyHtml = true;
            mail.Body = body;
            mail.IsBodyHtml = true;

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = senderInfo
            };

            try
            {
                await smtp.SendMailAsync(mail);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }

        private static string CreateBody(Models.MailModel model)
        {
            string body = string.Empty;
            using (StreamReader reader=new StreamReader(@"Resources\MailTemplate.html"))
            {
                body = reader.ReadToEnd();
            }
            body = body.Replace("{message}",model.Message);
            body = body.Replace("{infoname}",model.Name);
            body = body.Replace("{infomail}",model.Email);
                
            return body;
        }
    }

}
