using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._1_SRP.SRP.Solucao
{
    public static class ArquivoService
    {
        public static void Salvar(string conteudo, string caminho)
        {
            try
            {
                System.IO.File.WriteAllText(caminho, conteudo);
                Console.WriteLine($"Relatório salvo em {caminho}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao salvar arquivo: {ex.Message}");
            }
        }
    }
}
