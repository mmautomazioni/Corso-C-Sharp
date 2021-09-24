using System;
using System.Text;

    Libro libro1 = new Libro("L'isola misteriosa","Jules Verne");
    Console.WriteLine(libro1);//LIBRO
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
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("RECORD: Libro - ");
            builder.Append(Titolo);
            return builder.ToString();
        }
    }
    

