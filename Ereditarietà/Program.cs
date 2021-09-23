using System;
Libro libro1 = new Libro("L'isola misteriosa","Jules Verne");
LibroDigitale libro2 = new LibroDigitale("Neuromante","William Gibson","8 ore");
Console.WriteLine(libro1);
Console.WriteLine(libro2);
record Libro(string Titolo, string Autore);
record LibroDigitale(string Titolo, string Autore, string Durata):Libro(Titolo,Autore);
