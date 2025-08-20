using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._2_OCP
{
    public class PagamentoServiceViolacao
    {
        public void ProcessarPagamento(string metodo, decimal valor)
        {
            if (metodo == "Cartao")
            {
                Console.WriteLine($"Pagamento de {valor:C} processado com Cartão de Crédito.");
            }
            else if (metodo == "Pix")
            {
                Console.WriteLine($"Pagamento de {valor:C} processado via Pix.");
            }
            else if (metodo == "Boleto")
            {
                Console.WriteLine($"Pagamento de {valor:C} processado via Boleto.");
            }
            // E assim vai...
        }
    }
}
