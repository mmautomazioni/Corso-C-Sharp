﻿using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animale a  = new Insetto();
            Animale b = new Mammifero();
            a.MyMethod();
            b.MyMethod();
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
                 Console.WriteLine("Sto eseguendo MyMethod() della Sottoclasse Insetto.");
            }
        }
        public class Mammifero:Animale
        {
            public override void MyMethod()
            {
                 Console.WriteLine("Sto eseguendo MyMethod() della Sottoclasse Mammifero.");
            }
        }

    }
}