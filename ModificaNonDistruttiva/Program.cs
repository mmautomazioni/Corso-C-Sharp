using System;
Libro libro1 = new Libro("L'isola misteriosa","Jules Verne");
Libro libro2 = libro1 with {Autore = "Giulio Verne"};
//libro1.Autore="Pippo"; //ERRORE
/*--A volte può risultare utile modificare una proprietà, per fare ciò il C#
ci mette a disposizione un metodo di copia del record durante la quale la proprietà
viene modificata. Per duplicare un record che ripetiamo è un reference types
non basta l'opratore di assegnazione, ma per sdoppiare i reference e quindi
modificarne le proprietà occorre usare l'operatore with. Una volta modificate le
proprietà che occorre modificare libro2 è di nuovo un tipo immutabile.*/
Console.WriteLine(libro2.Autore);
record Libro(string Titolo, string Autore);