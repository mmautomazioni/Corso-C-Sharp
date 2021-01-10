using System;

namespace Iterazioni
{
    class Program
    {
        static void Main(string[] args)
        {
            //CICLO WHILE
            byte b = 0; 
            while (b<5)
            {
                Console.WriteLine(b);
                b++;
            }
            byte Z = 0; 
            //CICLO DO WHILE
            do
            {
                Console.WriteLine(Z);
                Z++;
            } while (Z>0 && Z<=5);
            //CICLO FOR
            for(int i=0; i<5; i++)
            {
                Console.WriteLine(i);
            }
            //L’istruzione for stamperà in questo caso (0 1 2 3 4).


            //LE ISTRUZIONI BREAK E CONTINUE
            for(int i=0; i<15; i++)
            {
                if (i%2 == 0)
                    Console.WriteLine(i);
                else
                    continue; //INCREMENTA i E TORNA IN TESTA AL CICLO	
                //ALTRE ISTRUZIONI
            }
            int y = 0;
            for(int i=0; i<15; i++)
            {
                if (y == 5)
                    break; //INTERROMPE IMMEDIATAMENTE IL CICLO.
                else
                    Console.WriteLine(i);
                y++;
            }
            // IL CICLO FOREACH
            string myVar = "pippo";
            foreach(char x in myVar)
            {
                Console.WriteLine(x);
            }


        }
    }
}
