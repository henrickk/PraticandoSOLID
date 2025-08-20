using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._3_LSP.LSP.violacao
{
    public class FuncionarioFreelancer : Funcionario
    {
        public override decimal CalcularPagamento()
        {
             throw new NotImplementedException("Funcionários freelancer não possuem pagamento fixo.");
        }
    }
}
