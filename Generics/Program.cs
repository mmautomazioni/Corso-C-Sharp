using System;
using System.Collections.Generic;
using System.Collections;
namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               /*--NULLABLE TYPES*/ 
               int myInt1 = 0; //SE PROVIAMO AD ASSEGNARE NULL A myInt1 OTTENIAMO UN ERRORE.
               //DEFINIZIONE DI UN NULLABLE TYPES
               int? myInt2 = 0;/*--PER FAR SI CHE IL TIPO INT DICHIARATO
                              POSSA ASSUMERE VALORI NULL OCCORRE METTERE UN ?
                              DOPO LA KEYWORD int*/
               myInt2=null;
               /*--TALE DICHIARAZIONE E' IN REALTA' UNA SCORCIATOIA, ESISTE UNA STRUTTURA
               NULLABLE<T> CHE E' EQUIVALENTE ALLA DICHIARAZIONE SOPRA RIPORTATA.*/
               Nullable<int> myInt = 0; //EQUIVALE A int? myInt = 0.
               myInt=null;
               if (myInt.HasValue)//QUESTO TEST FALLISCE IN QUANTO myInt = null.
                     Console.WriteLine(myInt.Value);
               myInt=100; 
               if (myInt.HasValue)
                     Console.WriteLine(myInt.Value);  
                myInt=null;     
                /*--NULL COALESCING OPERATOR ?? CI CONSENTE DI ASSEGNARE IL VALORE EFFETTIVO
                DI UN NULLABLE TYPES SE QUESTO E' PRESENTE OPPURE ASSEGNARE NOI UN VALORE
                DI DEFAULT SE PRESENTE NULL. */ 
                myInt1 = myInt ?? 0; /*--IN QUESTO CASO IL VALORE DI myInt è null 
                                    QUIDNI myInt1 ASSUMERA' IL VALORE 0. 
                                    SE myInt AVEVA VALORE 100 ALLORA myInt1
                                    AVREBBE ASSUNTO LO STESSO VALORE.*/
                Stampante s = new Stampante();
                int result1 = s.Stampa<int>(10,30);
                string result2 = s.Stampa<string>("Corso C#","Mario");
                MyGenericList<string> list = new MyGenericList<string>();
                list.Add("Mario Rossi");
                list.Add("Corso C#");
                list.Add("Mario Verdi");
                list.Sort();
                foreach(var item in list)
                {
                    Console.WriteLine(item);
                }
                MyClass<int> mc = new MyClass<int>();
                mc.Print(12,24);
                MyStruct<MyClass<int>> myStruct = new MyStruct<MyClass<int>>();
                myStruct.item = mc;
                Console.WriteLine(myStruct.ToString());     

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    public class Stampante
    {
        public T Stampa<T>(T a,T b)  
        {  
            Console.WriteLine($"{a + " " + b}");
            return a;
        } 
    }
    public class MyGenericArray <T>
    {
        private T [] array;
        public MyGenericArray (int size)
        {
            array = new T [size + 1];
        }
        public T getItem (int index)
        {
            return array [index];
        }
        public void setItem (int index, T value)
        {
            array [index] = value;
       
        }
    }
    public class MyGenericList<T>
    {
        List<T> lista = new List<T>();
        private T item;/*--QUANDO VOGLIAMO INIZIALIZZARE L'ELEMENTO GENERICO ITEM
                       NON SAPENDO A PRIORI SE T E' UN VALUE TYPE O UN REFERENCE TYPE
                       SI USA LA KEYWORD default CHE INIZIALIZZA A NULL I REFERENCE TYPE
                       A ZERO I VALORI NUMERICI E A NULL O A 0 I MEMBRI DELLE STRUCT, A 0 
                       SE SONO VALUE TYPE A NULL SE SONO REFERENCE TYPE.
                       */
        public MyGenericList()
        {
            item = default(T);
        }
        public void Add(T item)
        {
            try
            {
               lista.Add(item);
            }
            catch(Exception)
            {
                throw new Exception();
            } 
        }
        public void Remove(T item)
        {
            try
            {
               lista.Remove(item);
            }
            catch(Exception)
            {
                throw new Exception();
            }
            
        }
        public void Sort()
        {
            lista.Sort();
        }
        public IEnumerator GetEnumerator()
        {
            return lista.GetEnumerator();
        }

    }
    public interface IInterface<T> where T:struct
    {
        void Print(T arg1, T arg2);
    }
    public class MyClass<T>:IInterface<T> where T:struct
    {
        public void Print(T arg1, T arg2)
        {
            Console.WriteLine($"{arg1 + " " + arg2}");
        }
    }
    public struct MyStruct<T> where T:class
    {
        public T item;

        public override string ToString()
        {
            return item.ToString();
        }
    }

  }
}
    


