using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Azienda azienda = new Azienda("Pippo S.P.A",100,100_000_000); //INIZIALIZZAZIONE CON COSTRUTTORE
            Azienda a = new Azienda();//VENGONO INIZIALIZZATI GLI ATTRIBUTI DELLA STRUCT AI LORO VALORI DI DEFAULT.
            a.Fatturato=200_000_000m;
            Persona persona;  //LE VARIABILI DELLA STRUCT PERSONA NON SONO INIZIALIZZATE AI LORO VALORI DI DEFAULT
                              //A DIFFERENZA DELLE CLASSI.
            persona.nome="Marco";
            persona.cognome="Rossi";
            
        }
    }
    public struct Azienda
    {
        private string ragioneSociale;
        private int numeroDipendenti;
        public decimal Fatturato {get;set;}

        public Azienda(string ragioneSociale,int numeroDipendenti,decimal fatturato)
        {
            this.ragioneSociale=ragioneSociale;
            this.numeroDipendenti=numeroDipendenti;
            this.Fatturato=fatturato;
        }
    }
    struct Persona
    {
        public string nome;
        public string cognome;
    }
}
