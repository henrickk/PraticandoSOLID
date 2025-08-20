using PraticandoSOLID._3_LSP.LSP.Solucao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._3_LSP.LSP.Solucao
{
    public class FuncionarioCLT : Funcionario
    {
        public decimal Salario { get; set; } = 3000M;
        public decimal ValeRefeicao { get; set; } 

        public override decimal CalcularPagamento() =>  Salario; // salário fixo
        

        public override decimal Beneficios()
        {
            return ValeRefeicao; // benefícios adicionais, como vale transporte, alimentação, etc.
        }
    }
}
