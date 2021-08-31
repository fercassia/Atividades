using System;

public class Challenge
{
    public static int CalculaDistanciaBandaPercorre(int numeroRodadaEnsaios,int numeroShows)
    {
      var ensaioCasaAna = (0 + 500 + 500 + 500 + 250 + 1000)  * 2;
      var ensaioCasaBia = (0 + 500 + 500 + 500 + 750 + 1000) * 2;
      var ensaioCasaCadu = (0 + 500 + 500 + 500 + 500 + 750) * 2;
      var ensaioCasaDuda = (0 + 500 + 500 + 1000 + 1000 + 750) * 2;
      var ensaioCasaEdu = (0 + 500 + 500 + 500 + 250 + 500) * 2;
      var ensaioCasaFabi = (0 + 250 + 250 + 750 + 750 + 750) * 2;
      
      var kmEnsaios = ensaioCasaAna + ensaioCasaBia + ensaioCasaCadu + ensaioCasaDuda + ensaioCasaEdu + ensaioCasaFabi;      
      var kmShows = (750 + 1250 + 1250 + 750 + 750 + 500) * 2;
      
      var totalKmEnsaios = kmEnsaios * numeroRodadaEnsaios;
      var totalKmShows = kmShows * numeroShows;
      
      var kmTotal = totalKmEnsaios + totalKmShows;
      
      return kmTotal;
    }
}