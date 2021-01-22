using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
          MyClassA a = new MyClassA();
          IMyInterface i = a as IMyInterface;
          ((MyClassA)i).MyMethod2();//PER INVOCARE I METODI APPARTENENTI SOLO
                                    //A MyClassA OCCORRE FARE IL CASTING.
          MyClassB.MyMethod(i);
        }
        public interface IMyInterface
        {
            void MyMethod();
        }
        
        public class MyClassA : IMyInterface
        {
            public void MyMethod()
            {
                Console.WriteLine("MyMethod() di MyClassA");
            }
            public void MyMethod2()
            {
                Console.WriteLine("MyMethod2() di MyClassA");
            }
        }
        public class MyClassB
        {
            public static void MyMethod(IMyInterface myInterface)
            {
                myInterface.MyMethod();
            }
        }
       
    }
}

