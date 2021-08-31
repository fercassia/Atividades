using System;
public class Challenge
{
    public static int RetornaPessoasPreferemUmUnicoPalco(int quantidadePessoasEvento)
    {
      var totalABC = 0.03;
      
      var totalAC = 0.18 - totalABC;
      var totalAB = 0.20 - totalABC;
      
      var totalBC = 0.10 - totalABC;
      
      var gostaApenasDeA = quantidadePessoasEvento * (0.45 - totalAB - totalAC - totalABC);
      var gostaApenasDeB = quantidadePessoasEvento * (0.33 - totalAB - totalBC - totalABC);
      var gostaApenasDeC = quantidadePessoasEvento * (0.34 - totalAC - totalBC - totalABC);
      
      var totalDePessoasGostaUmPalco = gostaApenasDeA + gostaApenasDeB + gostaApenasDeC;
      
      return (int) totalDePessoasGostaUmPalco;
    }
}