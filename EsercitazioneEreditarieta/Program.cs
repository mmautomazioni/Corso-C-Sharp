using System;

namespace EsercitazioneEreditarieta
{
    class Program
    {
        static void Main(string[] args)
        {
          MyClassA a = new MyClassA();
          a.MyMethod();
          a.MyMethod1();
          a.MyProperty2 = "Corso C#.";
          Console.WriteLine(a.MyProperty2);
        }
    }
    public interface IMyInterface1
    {
        void MyMethod1();
        string MyProperty1 {get;set;}
    }
    public interface IMyInterface2
    {
        void MyMethod2();
        string MyProperty2 {get;set;}
    }
    public class MyClassA : MyClassB, IMyInterface1, IMyInterface2
    {
        public void MyMethod1()
        {
            Console.WriteLine("Sto implmentando MyMethod1() dell 'interfaccia IMyInteface1");
        }
        public string MyProperty1{get;set;}

        public void MyMethod2()
        {
            Console.WriteLine("Sto implmentando MyMethod2() dell 'interfaccia IMyInteface2.");
        }
        public string MyProperty2{get;set;}
    } 
    public class MyClassB
    {
        public void MyMethod()
        {
            Console.WriteLine("Sto eseguendo MyMethod() di MyClassB.");
        }
    }
}
