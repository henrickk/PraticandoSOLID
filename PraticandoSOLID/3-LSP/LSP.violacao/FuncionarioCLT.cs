using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._3_LSP.LSP.violacao
{
    public class FuncionarioCLT : Funcionario
    {
        public override decimal CalcularPagamento()
        {
            return 3000M; // salário fixo
        }
    }
}
