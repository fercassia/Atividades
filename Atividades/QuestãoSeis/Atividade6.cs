using System;
using System.Linq;
public class Challenge
{
    public static string[] GeraFrequenciaNota(int semitons)
    {
      var posSemitons = semitons % 12;
      var tonsAcima = semitons / 12;
      
      var crescente = new string[12] {"A", "A#", "B", "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#"};
      var decrescente = new string[12] {"Bb", "B", "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A"};
      
      var nota = string.Empty;
      var frequencia = string.Empty;
      
      if (semitons < 0)
      {
        nota = decrescente[11+posSemitons];
      }
      else
      {        
        nota = crescente[0+posSemitons];
      }
     
      var calc = 440*Math.Pow(2, ((double)posSemitons/(double)12));
      
      while (tonsAcima > 0)
      {
        tonsAcima--;
        
        calc = calc * 2;
      }
      
      while (tonsAcima < 0)
      {
        tonsAcima++;
        
        calc = calc / 2;
      }
      
      frequencia = "" + Math.Round(calc, 4);
      
      if (frequencia.Length.Equals(7))
      {
        frequencia = frequencia + "0";
      }
      
      var resp = new string[2] {frequencia,nota};
      
      return resp;
    }
}