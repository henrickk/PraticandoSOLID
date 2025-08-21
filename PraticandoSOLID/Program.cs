using PraticandoSOLID._1_SRP.SRP.Solucao;
using PraticandoSOLID._2_OCP.OCP.Solucao;
using PraticandoSOLID._3_LSP.LSP.Solucao;
using PraticandoSOLID._4_ISP.ISP.Solucao;
using PraticandoSOLID._4_ISP.ISP.Solucao.Interfaces;
using PraticandoSOLID._5_DIP.DIP.DIP.solucao;

class Program
{
    static void Main(string[] args)
    {
        // Exemplo de uso do SRP
        //var manager = new RelatorioManager();
        //manager.ProcessarRelatorio();

        // =================
        // Exemplo de uso do OCP 
        // Troque aqui o tipo de pagamento sem mudar o serviço
        //var pagamento = new PagamentoService(new PagamentoPix());
        //pagamento.ExecutarPagamento(200M);

        //pagamento = new PagamentoService(new PagamentoPayPal());
        //pagamento.ExecutarPagamento(450.50M);

        //pagamento = new PagamentoService(new PagamentoBoleto());
        //pagamento.ExecutarPagamento(100M);

        // =================
        // Exemplo de uso do LSP
        //var funcionarios = new List<Funcionario>
        //{
        //    new FuncionarioCLT { Nome = "João", ValeRefeicao = 500M},
        //    new FuncionarioFreelancer { Nome = "Maria", HorasTrabalhadas = 25, ValorPorHora = 40 },
        //    new FuncionarioEstagiario { Nome = "Ana", BolsaAuxilio = 1500M, ValeTransporte = 200M}
        //};

        //foreach (var f in funcionarios)
        //{
        //    Console.WriteLine(f.ResumoPagamento());
        //}

        // =================
        // Exemplo de uso do ISP

        // Corrigido: passar a instância de Ligavel (que implementa ILigavel) ao invés de chamar .Ligar(), e remover atribuição desnecessária

        //    var lampada = new Lampada();
        //    lampada.Ligar();

        //    var tv = new SmartTV(new Video(), new WiFi());

        //    tv.Ligar();
        //    //tv.Desligar();
        //    tv.MostrarVideo("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        //    tv.ConectarWiFi("Senha123");
        //    //tv.DesconectarWiFi();


        //    var caixaDeSom = new CaixaDeSom(musica: new Musica());

        //    caixaDeSom.Ligar();
        //    caixaDeSom.ReproduzirMusica("Veigh - Artista Genérico");

        // =================
        // Exemplo de uso do DIP
        var servicoEmail = new ServicoNotificacao(new NotificacaoEmailService());
        servicoEmail.Processar("cliente@teste.com", "Seu pedido foi confirmado!");

        var servicoSMS = new ServicoNotificacao(new NotificacaoSmsService());
        servicoSMS.Processar("11987654321", "Seu pedido foi enviado!");
    }
}