using System;

namespace CSHARP9
{
 
    class Program
    {
         /*--La parola chiave init rende assegnabile la proprietà solo
         all'inizializzazione dell'oggetto..*/       
       
        public record Money
        {
            public Currency Currency{get;init;}
            public decimal Amount {get;init;}
        }
        static void Main(string[] args)
        {
           var amount = new Money{Currency = Currency.Eur,Amount=10.00m};//Non posso più riassegnare le proprietà
           /*--OTTENIAMO UN RECORD IMMUTABILE OSSIA I SUOI VALORI
           NON POSSONO ESSERE RIASSEGNATI DOPO LA COSTRUZIONE. init
           NON E' UNA PREROGATIVA DI RECORD MA SI PUO' USARE ANCHE SULLE
           PROPRIETà DELLE CLASSI.*/                                                               
        }
    }
    public enum Currency
    {
        Eur,
        USD
    }
}
