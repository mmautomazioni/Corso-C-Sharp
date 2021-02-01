using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] x = new []{1,2,3,4,5,6,7,8,9,10};
           foreach(var item in x)
           {
               Console.WriteLine(item);
           }
           /*--ARRAY RETTANGOLARE 5 PER 5 DOVE OGNI PRIMA COLONNA
           VA IMPOSTATA A 0*/
           int[,] array = new int[5,5];
           int counter = 0;
           for(int y = 0; y < 5; y++)//loop nelle righe
           {
               for(int z= 0; z < 5; z++)//loop nelle colonne 
               {
                   ++counter;
                   array[y,z] = (z==0 ? 0 : counter);
               }
           }
           for(int y = 0; y < 5; y++)//loop nelle righe
           {
               for(int z= 0; z < 5; z++)//loop nelle colonne 
                   Console.Write($"{array[y,z]}");
               Console.Write("\n");     
           }
        }
    }
}
