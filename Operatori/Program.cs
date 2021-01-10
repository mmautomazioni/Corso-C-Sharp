using System;

namespace Operatori
{
    class Program
    {
        static void Main(string[] args)
        {
            //ESEMPI OPERATORI BINARI (2 OPERANDI)
            int x = 45;
            int y = 10;
            int somma = x+y;
            int prodotto = x*y;
            int divisione = x/y;
            byte modulo = (byte)(x % y);//CONVERSIONE ESPLICITA
            double division = (double)x/y;
            Console.WriteLine($"Divisione:{divisione},modulo{modulo},Divisione floating point {division}");
            //ESEMPI OPERATORI UNARI (1 OPERANDO)
            int x1 = 10;
            int y1 = -x1;
            y1 = y1 -3;
            //E' EQUIVALENTE A 
            y1-=3;
            x1=x1+1;
            //E' EQUIVALENTE A 
            x1+=1;
            int a = 10;
            int b = 5 + ++a;/*Notazione prefissa ++a che incrementa di 1
            ha la precedenza su tutti gli altri operatori. Quindi prima
            viene incrementata a poi si somma 5*/
            int a1 = 10;
            int b1 = 5 + a1++;/*Notazione postfissa a++ che incrementa di 1
            non ha la precedenza su tutti gli altri operatori. Quindi prima
            viene eseguita la somma e al termine viene incrementata a*/
            Console.WriteLine($"x1:{x1},y1:{y1},a:{a},b:{b},a1:{a1},b1:{b1}");
            //ESEMPI OPERATORI LOGICI
            int z = 10;
            int k = 8;
            bool v = (z>9&&k<10);
            bool s = (z>10||k>=8);
            bool negazione = !(z > 9 && k < 10);
            Console.WriteLine($"v:{v},s:{s},negazione:{negazione}");
            //ESEMPI OPERATORI SUI BIT (Bitwise)
            int binary_shift = 0b10101011;   //shiftato di 1 posizione a sinistra diventa 10101 0110  (342)
                                             //shiftato di una posizione a destra diventa 0101 0101 (85)   
                                                                                        
            int binary1 = 0b1010;
            int binary2 = 0b1010;
            int binary3 = binary1&binary2;
            int binary4 = 0b1111;
            int binary5 = 0b1010;
            int binary6 = binary4|binary5;
            int binary7 = 0b1111;
            int binary8 = 0b1010;
            int binary9 = binary7^binary8;
            int binary10 = binary_shift<<1;
            int binary11 = binary_shift>>1;
            Console.WriteLine($"AND Binario: {binary3}, Or Binario: {binary6}, XOR {binary9}");
            Console.WriteLine($"Shift a sinistra di 1 posizione: {binary10}, shift a destra di 1 posizione {binary11}");

        }
    }
}
