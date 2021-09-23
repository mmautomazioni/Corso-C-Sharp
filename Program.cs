using System;
    
    Libro libro1 = new Libro("L'isola misteriosa","Jules Verne");
    Libro libro2 = new Libro("L'isola misteriosa","Jules Verne");
    //Libro libro2 = new Libro("Neuromante","William Gibson");
    Console.WriteLine(libro1==libro2);//FALSE (TRUE con record)
    Console.WriteLine(libro1);//LIBRO
    /*--Dalla Console riceviamo False e Libro questo perchè la comparazione
    di due reference types si basa sui riferimenti, quindi essendoci due
    diversi reference che puntano a libro1 e libro2 l'uguaglianza sarà false.
    Inoltre visualizzare nel terminale l'oggetto che è associato ad una variabile
    provoca l'esecuzione del metodo ToString() della classe Object. Dal punto di vista
    del Data Model abbiamo un problema, vorremmo che la comparazine di due oggetti aventi la
    medesima proprietà dia Vero e non Falso. Per avere un comportamento più vicino ad un data
    model sostituiamo la parola chiave Class con record. Un record è sempre un reference types
    ma con caratteristiche particolari. Innanzitutto il confronto per uguaglianza 
    questa volta restituisce true come volevamo, questo perchè il record type ha usato
    una semantica a valore anzichè a riferimento e visto che le proprietà sono
    uguali il confronto ritorna True. Stampando a Console il valore di Libro1 questa
    volta il metodo ToString() torna Titolo e Autore di Libro1 */
    
    record Libro
    {
        public string Titolo {get;init;}
        public string Autore {get;init;}

        public Libro()
        {

        }
        public Libro(string titolo, string autore)
        {
            Titolo=titolo;
            Autore=autore;
        }
    }
