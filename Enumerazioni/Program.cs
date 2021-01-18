using System;

namespace Enumerazioni
{
    enum GiorniSettimana:byte{Lunedi=10,martedi=20,mercoledi=30,giovedi,venerdi,sabato,domenica};
    class Program
    {
        static void Main(string[] args)
        {
           GiorniSettimana gs = GiorniSettimana.domenica;
           if(gs==GiorniSettimana.domenica)
              Console.WriteLine("Domenica");
           int giorno = (int)GiorniSettimana.domenica;
           /*--POSSIAMO ACCEDERE ALL'INTERO CHE STA DIETRO ALL'ENUMERAZIONE CON UN SEMPLICE CAST*/
           Console.WriteLine(giorno);   
        }
    }
}
