using PraticandoSOLID._3_LSP.LSP.Solucao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._3_LSP.LSP.Solucao
{
    public class FuncionarioFreelancer : Funcionario
    {
        public int HorasTrabalhadas { get; set; }
        public decimal ValorPorHora { get; set; } = decimal.Zero;
        public override decimal CalcularPagamento() => HorasTrabalhadas * ValorPorHora; // pagamento baseado em horas trabalhadas
        
        public override decimal Beneficios()
        {
            return 0; // freelancers geralmente não têm benefícios fixos
        }
    }
}
