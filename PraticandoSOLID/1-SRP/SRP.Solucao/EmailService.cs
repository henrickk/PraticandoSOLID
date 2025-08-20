using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._1_SRP.SRP.Solucao
{
    public static class EmailService
    {
        public static void EnviarEmail(string de, string para, string assunto, string menssagem)
        {
                var mail = new MailMessage(de, para);
                var cliente = new SmtpClient("smtp.teste.com");
                mail.Subject = assunto;
                mail.Body = menssagem;
                cliente.Send(mail);
        }
    }
}