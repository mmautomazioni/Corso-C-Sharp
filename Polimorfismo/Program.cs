using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animale i = new Insetto();
            i.MyMethod();
            Animale.MyMethod2();
            
        }
        public abstract class Animale
        {
            public abstract void MyMethod();

            public static void MyMethod2()
            {
                Console.WriteLine("Sto eseguendo il metodo statico MyMethod2() della Superclasse.");
            }

            
        }
        public class Insetto:Animale
        {
            public override void MyMethod()
            {
                 Console.WriteLine("Sto eseguendo MyMethod() della Sottoclasse.");
            }
        }

    }
}
