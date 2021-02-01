using System;

namespace NullableReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #nullable enable //Abilitiamo il controllo dei valori null sui tipi reference
            string? s = null; /* NO WARNING DEL COMPILATORE
                              se inseriamo il ? di fatto stiamo dicendo al
                              compilatore che siamo consapevoli che la stringa deve essere trattata come un
                              Nullable types.*/
            Saluto(s!);/*WARNING DEL COMPILATORE per eliminare questo secondo warning
                       possiamo aggiungere il ? anche nell'argomento del metodo o il
                       !(null-forgiving operator)*/
        }
        static void Saluto(string nome)/*ELIMINATO SECONDO WARNING
                                         con il ? di fatto diciamo al compilatore
                                         di non generare un warning in quanto la
                                         gestione del valore null viene effettuata
                                         all'interno del metodo.Ma c'è un'altro
                                         operatore che ci consente di evitare il ?
                                         sul parametro del metodo e si chiama 
                                         null-forgiving operator !*/
        {
            if(nome!=null)
                Console.WriteLine($"Hello {nome}");
        }
    }
}
