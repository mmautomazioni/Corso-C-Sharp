using System;
            /*--Cicliamo con un loop tutti gli argomenti passati dalla riga di comando
            all'array di stringhe args. Fatto ciò andiamo ad eliminare dal programma
            il namespace, la classe program e il metodo Main*/
            if(args.Length > 0)
            {
                foreach (var item in args)
                    Console.WriteLine(item);
            }
        

