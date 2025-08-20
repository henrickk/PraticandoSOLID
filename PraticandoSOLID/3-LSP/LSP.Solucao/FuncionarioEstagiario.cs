using PraticandoSOLID._3_LSP.LSP.Solucao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PraticandoSOLID._3_LSP.LSP.Solucao
{
    public class FuncionarioEstagiario : Funcionario
    {
        public decimal BolsaAuxilio { get; set; }
        public decimal ValeTransporte { get; set; }

        public override decimal CalcularPagamento() => BolsaAuxilio; // pagamento baseado na bolsa auxílio
        
        public override decimal Beneficios()
        {
            return ValeTransporte; // benefícios adicionais, como vale transporte
        }

    }
}