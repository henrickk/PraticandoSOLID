using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._3_LSP.LSP.Solucao
{
    public abstract class Funcionario
    {
        public required string Nome { get; set; }
        public abstract decimal CalcularPagamento();
        public abstract decimal Beneficios();

        public virtual string ResumoPagamento()
        {
            var total = CalcularPagamento() + Beneficios();
            return $"{Nome} vai receber { total:C}";
        }
    }
}
