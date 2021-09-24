using System;
using System.Text;

    Libro libro1 = new Libro("L'isola misteriosa","Jules Verne");
    LibroDigitale libro2 = new LibroDigitale("L'isola misteriosa","Jules Verne", "6 ORE");
    Console.WriteLine(libro1);//LIBRO
    Console.WriteLine(libro2);
    record Libro
    {
        #nullable enable
        public string Titolo {get;init;}
        public string Autore {get;init;}

        #nullable disable
        public Libro()
        {

        }
        public Libro(string titolo, string autore)
        {
            Titolo=titolo;
            Autore=autore;
        }
        //OVERRIDE DI ToString()
        /*--Inserendo la keyword sealed in C# 10 di fatto stiamo
        impedendo l'override del metodo ToString() nei sotto types
        del record Libro cioè non è più possibile fare l'override
        del metodo ToString() nel tipo derivato LibroDigitale.*/
        public sealed override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("RECORD: Libro - ");
            builder.Append(Titolo);
            return builder.ToString();
        }
    }
    record LibroDigitale:Libro
    {
        #nullable enable
        public string Durata {get;init;}
    
        #nullable disable
        public LibroDigitale()
        {

        }
        public LibroDigitale(string titolo,string autore, string durata)
        {
            Titolo=titolo;
            Autore=autore;
            Durata=durata;
        }
        //OVERRIDE DI ToString
        public override string ToString()
        {
            string s = base.ToString();
            StringBuilder builder = new StringBuilder();
            builder.Append(s);
            builder.Append("-- DURATA: -- ");
            builder.Append(Durata);
            return builder.ToString();

        }
    }

