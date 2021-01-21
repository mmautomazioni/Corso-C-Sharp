using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Insetto i = new Insetto();
            i.MyMethod();
        }
        public class Animale
        {
            public virtual void MyMethod()
            {
                Console.WriteLine("Sto eseguendo MyMethod() della Superclasse.");
            }
        }
        public class Insetto:Animale
        {
            public override void MyMethod()
            {
                 base.MyMethod();
                 Console.WriteLine("Sto eseguendo MyMethod() della Sottoclasse.");
            }
        }

    }
}

