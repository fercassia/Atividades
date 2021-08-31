using System;

public class Challenge
{
    public static string TamanhoSetorBusca(int areaMaior,int areaMenor)
    {   
      var areaDeProcura = ((double)(areaMaior - areaMenor)/8d);
      
      var resultadoDaAreaDeProcura = areaDeProcura.ToString();
      
      return resultadoDaAreaDeProcura;
    }
}