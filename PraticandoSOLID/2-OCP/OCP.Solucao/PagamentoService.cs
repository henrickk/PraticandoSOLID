using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._2_OCP.OCP.Solucao
{
    public class PagamentoService
    {
        private readonly PagamentoBase _pagamento;

        public PagamentoService(PagamentoBase pagamento)
        {
            _pagamento = pagamento;
        }

        public void ExecutarPagamento(decimal valor)
        {
            _pagamento.Pagar(valor);
        }
    }

}