using System;

namespace Eccezioni
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            Console.Write("Inserisci il Dividendo: ");
            string dividendo = Console.ReadLine();
            Console.Write("Inserisci il Divisore: ");
            string divisore = Console.ReadLine();
            try
            {
                int num1 = Convert.ToInt32(dividendo);
                int num2 = Convert.ToInt32(divisore);
                result = Divisione(num1,num2);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine($"Hai inserito lo zero come divisore, eccezione generata {e.Message}");
            }
            catch(InvalidCastException e)
            {
                Console.WriteLine($"Hai inserito valori non validi eccezione generata {e.Message}");
            }
            catch(Exception e)
            {
                Console.WriteLine($"Si è verificata questa eccezione: {e.Message}");
            }
            finally
            {
                Console.WriteLine(result);
            }
           
        }
        static int Divisione(int a, int b)
        {
            try
            {
               return a/b; 
            }
            catch(Exception ex)
            {
                throw new DivideByZeroException("Divisione per zero",ex);
            }
            
        }
    }
}
