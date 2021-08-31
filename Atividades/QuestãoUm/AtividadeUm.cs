using System;

public class Challenge
{
    public static int RetornaTempoArenaEmMilisegundos(string distancia, int velocidade = 340)
    {
      try
      {
        var distanciaDaArenaMetros = double.Parse(distancia) * 1000;
        
        var tempoEmMiliSegundos = (distanciaDaArenaMetros / (double)velocidade) * 1000d;
        
        return (int)Math.Round(tempoEmMiliSegundos);
      }
      catch (Exception)
      {
        Console.WriteLine("O numero informado esta invalido");
        throw;
      }
    }
}