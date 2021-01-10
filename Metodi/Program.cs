using System;

namespace Metodi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chiamata a metodo della classe Console.");
            int x = Program.Somma(50,25);
            Console.WriteLine(x); //75
            float y = Somma(14.1f,16.9f);
            Console.WriteLine(y); 
            decimal z = Somma(14.1m,16.9m);
            Console.WriteLine(z); 
            int fattoriale = Fattoriale(10);
            Console.WriteLine(fattoriale);
            int n = 144;
            Console.WriteLine($"la radice quadrata di {n} è:{RadiceQuadrata(n)}");
        }
        //DEFINIZIONE DEL METODO SOMMA
        static int Somma(int a, int b)
        {
            int result = a+b;
            return result;
        }
        //OVERLOAD DEL METODO SOMMA
        static float Somma(float a, float b)
        {
            float result = a+b;
            return result;
        }
        //OVERLOAD DEL METODO SOMMA
        static decimal Somma(decimal a, decimal b)
        {
            decimal result = a+b;
            return result;
        }
        //METODI RICORSIVI CALCOLARE IL FATTORIALE DI UN NUMERO.
        static int Fattoriale(int n)
        {
            if(n==0)   //CASO BASE CHE PERMETTE DI USCIRE DAL LOOP.
              return 1;
            return n * Fattoriale(n-1);
        }
        static double RadiceQuadrata(int a)
        {
            return Math.Sqrt(a);
        }
    
    }
}
