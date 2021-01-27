using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int,double> myAction = Somma;
            myAction+=Differenza;
            myAction+=Moltiplicazione;
            myAction.Invoke(10,89.98);            
            static void Somma(int arg1, double arg2)
            {
                 Console.WriteLine($"Somma: {arg1 + arg2}");
            }
            static void Differenza(int arg1, double arg2)
            {
                Console.WriteLine($"Differenza: {arg1 - arg2}");
            }
            static void Moltiplicazione(int arg1, double arg2)
            {
               Console.WriteLine($"Moltiplicazione: {arg1 * arg2}");
            }
            Func<double,double> MyFunc = RadiceQuadrata;
            double result = MyFunc.Invoke(144);
            Console.WriteLine(result);
            static double RadiceQuadrata(double arg1)
            {
                return Math.Sqrt(arg1);
            }
        }
    }
}
