using System;

namespace DefaultInterface
{
    class Program
    {
        static void Main(string[] args)
        {
           MyClass mc = new MyClass();
           mc.MyMethod("Mario");
           //Console.WriteLine(mc.MyMethod2("Susanna"));
           bool result = (mc as IInterface).MyMethod2("Susanna");//Invocazione corretta.
           Console.WriteLine(result);
        }
    }
    public interface IInterface
    {
        void MyMethod(string arg);
        /*--Supponiamo che in un secondo momento venga definita
        una nuova implementazione di MyMethod chiamata MyMethod2
        e che il programmatore che gestisce la classe non sia al
        corrente di ciò o non sappia cosa debba fare questa nuova
        implementazione. Ovviamentene MyClass non può essere compilata
        in quanto non implementa MyMethod2. In casi come questi
        il C# a partire dalla versione 8 ci viene incontro potendo
        implementare MyMethod2 direttamente in IInterface*/
        bool MyMethod2(string arg)=> arg.StartsWith('S');
        /*--Una volta implementato MyMethod2 nell'interfaccia
        supponiamo che il programmatore che gestisce la classe
        cha la implementa voglia dare una sua implementazione.
        Se creiamo una istanza di MyClass e invochiamo Method2
        il codice eseguito sarà quello ridefinito in MyClass,
        in una sorta di override. Se rimuoviamo la definizione
        di MyMethod2 dalla classe magari perchè vogliamo
        che venga eseguita l'implementazione di default
        nella interface otteniamo un errore. Il compilatore
        vuole che indichiamo esplicitamente su quale interface
        intendiamo richiamare MyMethod2 perchè potrebbero
        essere più interface che dichiarano un metodo
        con la stesso nome e signature.*/
    }
    public class MyClass:IInterface
    {
        public void MyMethod(string nome) => Console.WriteLine(nome.ToUpper());
        //public bool MyMethod2(string nome)=>nome.EndsWith('a');
        
    }

}
