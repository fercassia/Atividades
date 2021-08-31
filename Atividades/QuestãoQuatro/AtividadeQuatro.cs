using System;
public class Challenge
{
    public static bool RetornaSeHaEcoNoEstudio(int distancia)
    {
      try
      {
        var distanciaDoEstudio = Convert.ToDouble(distancia);
        var distanciaMinimaParaCausarEco = (340 * 0.1) / 2;

        if (distanciaDoEstudio <= distanciaMinimaParaCausarEco)
        {
          return false;
        }
        return true;
      }
      catch (Exception)
      {
          Console.WriteLine("O valor fornecido não pôde ser convertido");
          throw;
      }
    }
}