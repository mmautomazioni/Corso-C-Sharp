using System;

namespace LambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string> hello = () => "Hello World!";
            Console.WriteLine(hello());
            Func<string,string> hello2 = (string nome) => $"Hello {nome}";
            Console.WriteLine(hello2("Mario"));
            Action hello3 = () => Console.WriteLine("Hello!");
            hello3();
            /*SUPPONIAMO DI CALCOLARE IL MASSIMO TRA DUE NUMERI INTERI
            IL TIPO DEI PARAMETRI SI PUO' OMETTERE IN QUANTO IL COMPILATORE
            E' IN GARDO DI INFERIRE IL GIUSTO TIPO*/
            Func<int,int,int> maxint = (num1,num2)=> Math.Max(num1,num2);
            Console.WriteLine(maxint(12,68));
             /*SUPPONIAMO DI CALCOLARE IL MASSIMO TRA TRE DOUBLE
            IL TIPO DEI PARAMETRI SI PUO' OMETTERE IN QUANTO IL COMPILATORE
            E' IN GARDO DI INFERIRE IL GIUSTO TIPO*/
            Func<double,double,double,double> maxdouble = (arg1,arg2,arg3) => Math.Max(Math.Max(arg1,arg2),arg3);
            Console.WriteLine(maxdouble(12.987,68.789,98.876));
            /*--DATA UNA CERTA DATA DI NASCITA LA PERSONA
            PUO' GUIDARE O MENO NELLO STATO ITALIANO.*/
            Func<DateTime,bool> canDrive = (data) => data.AddYears(18) <= DateTime.Today;
            Console.WriteLine(canDrive(new DateTime(2003,02,01)));
            /*--DATE IN INPUT DUE DATE VOGLIAMO SAPERE LA MAGGIORE*/
            Func<DateTime,DateTime,DateTime> maxData = (data1,data2)=> data1 > data2 ? data1 : data2;
            Console.WriteLine(maxData(new DateTime(2020,12,31),DateTime.Today));   
            /*--ESEMPIO DI STATEMENT LAMBDA*/
            Func<int,int,int> somma = (numero1,numero2) =>{
                return numero1+numero2;
            };
            Console.WriteLine(somma(10,5));   
            Console.WriteLine(HelloWorld("Mario"));
            MyClass mc = new MyClass("Mario");
            Console.WriteLine(mc.Nome);
        
        }
        static string Hello(string nome)
        {
            return $"Ciao {nome}";
        }
        /*EXPRESSION-BODYED MEMBERS*/
        static string HelloWorld(string nome) => $"Hello World {nome}";
    }
    /*EXPRESSION-BODYED MEMBERS*/
    public class MyClass
    {
        private string nome;
        public string Nome
        {
            get => nome.ToUpper();
            set => nome=value;
        }
        /*EXPRESSION-BODYED MEMBERS*/
        public MyClass(string nome) => Nome = $"Ciao {nome}";
    }
}
