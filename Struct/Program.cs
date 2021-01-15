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
            //ESERCITAZIONE CON LE STRUCT
            MyClass mc = new MyClass();
            MyStruct ms = new MyStruct();
            mc.eta=40;
            mc.nome="Mario";
            ms.eta=60;
            ms.nome="Fabio";
            Console.WriteLine($"Prima della chiamata mc.eta=: {mc.eta} ms.eta=: {ms.eta}");
            MyMethod(mc,ms,"Pippo",20);
            Console.WriteLine($"Dopo la chiamata mc.eta=: {mc.eta} ms.eta=: {ms.eta}");
            /*--LE STRUCT ESSENDO DEI VALUE TYPES PASSANO AL METODO UNA COPIA DEI LORO ATTRIBUTI
            AL RITORNO DAL METODO I VALORI NON SONO MODIFICATI. vICEVERSA LE CLASSI ESSENDO
            DEI REFERENCE TYPES PASSANO UNA COPIA DEL RIFERIMENTO CHE PUNTA ALLA MEDESIMA STRUTTURA
            CREATA NELL'HEAP, AL RITORNO L'ISTANZA mc SARA' MODIFICATA.*/
        }
        static void MyMethod(MyClass mc, MyStruct ms, string myString, int myInt )
        {
            mc.nome=myString;
            mc.eta=myInt;
            ms.nome=myString;
            ms.eta=myInt;
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
    public class MyClass
    {
        public string nome;
        public int eta;
    }
    public struct MyStruct
    {
        public string nome;
        public int eta;
    }

}
