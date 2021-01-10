using System;

namespace Conversioni
{
    class Program
    {
        static void Main(string[] args)     
        {
            //ESEMPI DI CAST IMPLICITO
            int a = 1200;
            double d = (1234.89 + a);
            byte b = 255;
            int c = b;
            //ESEMPI DI CAST IMPLICITO
            float f = 2345.89765f;
            int g = 100 + (int)f;
            long h = 123567789;
            int z = 5 + (int)h;
            //ESEMPIO DI OVERFLOW
            int x = 1235678654; //dovrebbe restituire 1.235.678.655
            short k = (short)(1 + x);
            Console.WriteLine("overflow {0}",k);
            //LA CLASSE CONVERT
            int m = 1200;
            string s = Convert.ToString(m);
            Console.WriteLine("Conversione di un intero in stringa {0}",s);
            
        }
    }
}
