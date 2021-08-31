using System;
public class Challenge
{
    public static int RetornaGuicheIngresso(int ingressoNumero)
    {
      var numeroGuiche = 0;
      var pessoaIniciaGuiche = 0;
      var pessoaFinalizaGuiche = 0;
      
      var eGuicheCorreto = false;
           
      if (ingressoNumero.Equals(0))
      {
        return 0;
      }
        
      while (eGuicheCorreto.Equals(false))
      {
        var numeroDePessoasNoGuiche = ((numeroGuiche)*2)+1;  
        numeroGuiche++;
        
        if (numeroGuiche.Equals(1))
        {
          pessoaIniciaGuiche = 1;
          pessoaFinalizaGuiche = 1;
        }
        else 
        {
          pessoaIniciaGuiche = pessoaFinalizaGuiche + 1;
          pessoaFinalizaGuiche = pessoaIniciaGuiche + numeroDePessoasNoGuiche - 1;
        }
        
        if (ingressoNumero >= pessoaIniciaGuiche && ingressoNumero <= pessoaFinalizaGuiche)
        {
          eGuicheCorreto = true;
        }
      }
      
      return numeroGuiche; 
    }
}