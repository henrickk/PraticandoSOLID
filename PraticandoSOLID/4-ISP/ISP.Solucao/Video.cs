using PraticandoSOLID._4_ISP.ISP.Solucao.Interfaces;

public class Video : IVideo
{
    public void MostrarVideo(string url) 
    {
        Console.WriteLine($"Exibindo vídeo de: {url}");
    }
}