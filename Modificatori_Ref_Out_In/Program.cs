using System;

namespace Modificatori_Ref_Out_In
{
    public class MyClass
    {
        public int x = 10;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass mc = new MyClass();
            int k = 10;
            MyMethod(mc,k);
            Console.WriteLine($"{mc.x} {k}");//x=20, k=10
        }
        static void MyMethod(in MyClass y, in int k)
        {
            //y= new MyClass();ERRORE DEL COMPILATORE
            //k=20;ERRORE DEL COMPILATORE
            y.x=20;  
        }
    }
}
