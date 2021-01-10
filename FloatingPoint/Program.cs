using System;

namespace FloatingPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            float f = 18.78965f;
            double d = 987.89;
            decimal dc = 12.987654323456m;
            double d1 = 8.1e-8;
            float f1 = 7.897e12f;
            //Tipo Boolean che non c'entra nulla con i floating point ma che per comodità riporto quì.
            //ammette solo due valori, vero o falso, true(1) false(0) occupa 1 Byte.
            bool myBool1 = true;
            bool myBool2 = false;
            Console.WriteLine($"f:{f}, d:{d}, dc:{dc}, d1:{d1}, f1:{f1}, myBool1{myBool1},myBool2:{myBool2}");
            
            
        }
    }
}
