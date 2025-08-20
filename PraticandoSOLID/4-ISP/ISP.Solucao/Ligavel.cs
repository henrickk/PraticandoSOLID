using PraticandoSOLID._4_ISP.ISP.Solucao.Interfaces;

public class Ligavel : ILigavel
{
    public void Ligar()
    {
        Console.WriteLine("Ligado");
    }

    public void Desligar()
    {
        Console.WriteLine("Desligado");
    }
    
}