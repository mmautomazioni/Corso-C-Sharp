using System;

namespace ValueReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //PASSAGGIO DI PARAMETRI PER VALORE
            int x = 24;
            ByValue(x);
            Console.WriteLine(x);//variabile x non modificata
            //PASSAGGIO PARAMETRI PER RIFERIMENTO
            //valore di y prima della chiamata al metodo
            int[]y = new[]{20,30};
            foreach(int a in y)
            {
                Console.WriteLine($"valori del parametro y prima della chiamata al metodo:{a}");
            }
            ByReference(y);
             //valore di y dopo la chiamata al metodo
            foreach(int a in y)
            {
                Console.WriteLine($"valori del parametro y dopo la chiamata al metodo:{a}");
            }
        }
        static void ByValue(int y)
        {
              y= 100;
              return;
        }
        static void ByReference(int[] x)
        {
            x[0] = 10;
            return;
        }
    }
}
