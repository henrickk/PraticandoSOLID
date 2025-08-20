using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._1_SRP.SRP.Solucao
{
    public static class RelatorioService
    {
        public static string GerarRelatorio()
        {
            Console.WriteLine("Gerando relatório...");
            return $"Relatório gerado em {DateTime.Now}\nVendas: 150\nClientes: 30";
        }
    }
}