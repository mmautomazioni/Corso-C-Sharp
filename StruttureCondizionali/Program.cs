using System;

namespace StruttureCondizionali
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            Console.WriteLine("Inserisci la tua età....");
            String eta = Console.ReadLine();
            age = Convert.ToInt32(eta);
            Console.WriteLine($"Hai introdotto {age} anni.");
            if(age<18)
               Console.WriteLine("Nello stato Italiano sei minorenne quindi non puoi guidare.");
            else if(age==18)  
               Console.WriteLine("Nello stato Italiano sei maggiorenne quindi puoi guidare.");   
            else if (age>18 && age<90)  
               Console.WriteLine("Nello stato Italiano sei maggiorenne quindi puoi guidare."); 
            else
               Console.WriteLine($"Hai immesso un valore non valido hai {age} anni"); 
            //L'OPERATORE TERNARIO */
            Console.WriteLine((age==18 || (age>18 && age<90))? "Sei maggiorenne puoi guidare":"Non hai l'età per guidare.");   

            //LO STATEMENT SWITCH
            int myVar = 50;
            switch (myVar)
            {
                case 10:
                {
                    Console.WriteLine(10);
                    break;
                }
                case 20:
                case 30:
                case 40:
                {
                    Console.WriteLine("20 ,30, 40");
                    break;
                }
                case 50:
                {
                    Console.WriteLine(50);
                    break;
                }
                default:
                {
                    Console.WriteLine("un altro valore");
                    break;
                }
            } 
            /*--VEDIAMO COME POSSIAMO USARE LO SWITCH PER GESTIRE L'ETA'
            DI UNA PERSONA.*/
            switch(age)
            {
                case <18:
                {
                    Console.WriteLine("Nello stato Italiano sei minorenne quindi non puoi guidare.");
                    break;
                }
                case 18:
                case int when (age > 18 && age < 90 ):
                {
                    Console.WriteLine("Nello stato Italiano sei maggiorenne quindi puoi guidare.");
                    break;
                }
                default:
                {
                    Console.WriteLine($"Hai immesso un valore non valido {age} anni."); 
                    break;
                }
            }  
        } 
    }
}
