using System;
namespace IndiciRange
{
    class Program
    {
        static void Main(string[] args)
        {
           //INDICI 
           string[] myArray = {"primo","secondo","terzo","quarto"};
           Index primo = 0;
           Index ultimo = ^1;
           string x = myArray[primo];
           string y = myArray[ultimo];
           Console.WriteLine($"{x} {y}");
           string s1 = myArray[^1];
           string s2 = myArray[^2];
           Console.WriteLine($"{s1} {s2}");
           //RANGE
           string[]a = myArray[..2];/*--partiamo dall'inizio dell'array
                                    e ci fermiamo prima dell'indice specificato 2*/
           foreach(var item in a)
           {
               Console.WriteLine(item);
           }
           string[]b = myArray[2..];/*--Parte dall'indice due compreso fino alla fine*/
           foreach(var item in b)
           {
               Console.WriteLine(item);
           }
           string[]c = myArray[1..3];/*--Parte dall'indice 1 incluso fino all'indice 3 escluso*/
           foreach(var item in c)
           {
               Console.WriteLine(item);
           }
        }
    }
}
