using System;

namespace Variabili
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar;   //dichiarazione di una variabile
                         //per i commenti su una riga anteponiamo il doppio slash//.
                         //I commenti su più righe iniziano con /* e terminano con */
            //Console.WriteLine($"myVar vale:{myVar}"); //PRODUCE UN ERRORE DI COMPILAZIONE, myVar non inizializzata.
            /*Come si vede provando ad utilizzare myVar senza averla inizializzata si produce
            un errore di compilazione subito segnalato da Visual Studio Code.*/
            myVar = 120;
            Console.WriteLine($"myVar vale:{myVar}"); 
            //dichiarazione e inizializzazione di più variabili su una riga.
            int x = 120, y = 180, z = 50;
            Console.WriteLine($"x:{x},y:{y},z:{z}"); 
            //Assegiamo ad y il valore di x.
            y = x;
            Console.WriteLine($"y adesso vale:{y}, mentre x:{x}");
            /*Come vedi per stampare a video i risultati ho utilizzato
            quella che viene chiamata interpolazione di stringhe.
            in pratica bisogna anteporre alla stringa il $ e usare
            i valori delle variabili tra parentesi graffe. C'è anche un altro 
            metodo che ora ti faccio vedere e che si basa su segnaposti.*/
             Console.WriteLine("y adesso vale:{0}, mentre x:{1}",y,x);
        }
    }
}
