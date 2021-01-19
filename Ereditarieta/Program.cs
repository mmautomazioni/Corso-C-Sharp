using System;

namespace Ereditarieta
{
    public class Program
    {
        public static void Main(string[] args)
        {
           Mammifero m = new Mammifero("Pippo",20);   
        }
    }
    public class Animale
    {
        private int myInt;
        public string MyProperty {get;set;}
        public Animale(int myInt)
        {
             this.myInt=myInt;
        }
        public void Respira()
        {
            Console.WriteLine("Respira");
        }
    }
    public class Mammifero : Animale
    {
        private string myString;
        public Mammifero(string myString,int myInt):base(myInt)
        {
              this.myString=myString;
        }
        
    }
}

