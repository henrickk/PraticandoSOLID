using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._1_SRP.SRP.Violacao
{
    // 🚨 Esta classe tem muitas responsabilidades ao mesmo tempo!
    // Ela gera, salva e envia relatório. Isso viola o SRP (Single Responsibility Principle).
    public class RelatorioService
    {
        public void GerarRelatorio()
        {
            Console.WriteLine("Gerando relatório...");

            // 🚨 Responsabilidade 1: Gerar conteúdo do relatório
            string conteudo = $"Relatório gerado em {DateTime.Now}\nVendas: 150\nClientes: 30";

            // 🚨 Responsabilidade 2: Salvar em arquivo
            SalvarEmArquivo(conteudo);

            // 🚨 Responsabilidade 3: Enviar e-mail
            EnviarEmail(conteudo);

            Console.WriteLine("Relatório gerado, salvo e enviado com sucesso!");
        }

        // 🚨 Aqui está responsabilidade de persistência (salvar em arquivo)
        private void SalvarEmArquivo(string conteudo)
        {
            string caminho = "relatorio.txt";
            File.WriteAllText(caminho, conteudo);
            Console.WriteLine($"Relatório salvo em {caminho}");
        }

        // 🚨 Aqui está responsabilidade de comunicação externa (enviar e-mail)
        private void EnviarEmail(string conteudo)
        {
            try
            {
                var mail = new MailMessage("empresa@teste.com", "cliente@teste.com");
                mail.Subject = "Relatório Gerado";
                mail.Body = conteudo;

                using (var smtp = new SmtpClient("smtp.teste.com"))
                {
                    smtp.Credentials = new NetworkCredential("usuario", "senha");
                    smtp.Send(mail);
                }

                Console.WriteLine("Relatório enviado por e-mail!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao enviar e-mail: {ex.Message}");
            }
        }
    }

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        RelatorioService relatorio = new RelatorioService();
    //        relatorio.GerarRelatorio();
    //    }
    //}
}