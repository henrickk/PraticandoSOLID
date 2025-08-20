using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._1_SRP.SRP.Solucao
{
    public class RelatorioManager
    {
        public void ProcessarRelatorio()
        {
            string conteudo = RelatorioService.GerarRelatorio();

            ArquivoService.Salvar(conteudo, "relatorio.txt");

            EmailService.EnviarEmail(
                "empresa@teste.com",
                "cliente@teste.com",
                "Relatorio Gerado",
                conteudo
            );
        }
    }
}
