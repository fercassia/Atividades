using System;

public class Challenge
{
  public static int RetornaTempoMinimoEmMinutos(int p,int s,int n)
  {
    var pessoasPorPortao = Math.Round(((double)p/(double)n), MidpointRounding.ToPositiveInfinity);
    
    var mediaEmSegundos = Math.Round((pessoasPorPortao*(double)s), MidpointRounding.ToPositiveInfinity);
    
    var mediaEmMinutos = Math.Round((mediaEmSegundos/60d), MidpointRounding.ToPositiveInfinity);

    return (int)Math.Round(mediaEmMinutos, MidpointRounding.ToPositiveInfinity);
  }
}