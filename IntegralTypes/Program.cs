using System;
using System.Text;

namespace IntegralTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 90;        //1 byte unsigned da 0 a 255
            int x = 120;        //4 byte signed da -2.147.483.648 a 2.147.483.647
            short y = -90;      //2 byte signed da -32.768 a 32.767
            long l = 100;       //8 byte signed da -9.223.372.036.854.775.808 a 9.223.372.036.854.775.807
            Console.WriteLine($"b:{b},x:{x},y:{y};l:{l}");
            sbyte sb = -90;     //1 byte signed da -128 a 127
            uint x1 = 1200;     //4 byte unsigned da 0 a 4.294.967.295
            ushort y1 = 190;    //2 byte unsigned da 0 a 65.535
            ulong l1 = 1100;    //8 byte unsigned da 0 a 18.446.744.073.709.551.615
            char c = 'A';       /*2 byte unsigned da 0 a 65.535 rappresenta un codepoint                       
                                di un carattere Unicode.*/
            //usare int per scrivere un codice binario e esadecimale
            int b0 = 0b1111; /*per dichiarare un numero in binario basta anteporre 
            0b al numero binario.*/                             
            int ex = 0x1FB76; /*per dichiarare un numero esadecimale basta 
            anteporre 0x al numero esadecimale.*/ 
            /*COME STAMPARE NEL TERMINALE UN CARATTERE UNICODE
            SE AL MOMENTO NON COMPRENDI ALCUNE PARTI DI CODICE
            NON PREOCCUPARTI TUTTO SARA' PIU' CHIARO PIU' AVANTI
            NEL CORSO*/                              
            int razzetto = 0x1F680;//Codice esadecimale del carattere unicode da stampare
            string s1;
            s1 = Char.ConvertFromUtf32(razzetto);
            int lenght2 = s1.Length;
            char[] arr = s1.ToCharArray();
            Rune r = new Rune(arr[0], arr[1]);
            Console.OutputEncoding = System.Text.Encoding.Unicode;  
            //INTERPOLAZIONE DI STRINGHE MOLTO PIU' COMPATTA E FACILE DA LEGGERE
            Console.WriteLine($"sb:{sb},x1:{x1},y1:{y1},l1:{l1},c:{c},r:{r},b0:{b0},ex:{ex}");
           
        }
    }
}
