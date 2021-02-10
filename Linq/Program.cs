using System;
using System.Linq;
using System.Collections.Generic;
namespace Linq
{
    public class Program
    {
        static void Main(string[] args)
        {
           List<Persona> persone = new List<Persona>() {
               new Persona {Nome="Mario",Cognome="Bianchi",Eta=55,Altezza=170,Peso=80},
               new Persona {Nome="Mario",Cognome="Rossi",Eta=40,Altezza=160,Peso=80},
               new Persona {Nome="Mario",Cognome="Rossi",Eta=40,Altezza=178,Peso=85},
               new Persona {Nome="Franco",Cognome="Rossi",Eta=60,Altezza=180,Peso=70},
               new Persona {Nome="Susanna",Cognome="Verdi",Eta=25,Altezza=170,Peso=60},
               new Persona {Nome="Luigi",Cognome="Bianchi",Eta=55,Altezza=175,Peso=90}
            };
            Func<Persona, bool> myFunc = (Persona p) => p.Nome =="Mario";
            IEnumerable<Persona> pers = persone.Where(myFunc);//Abbiamo fornito il predicate che l'intellisense suggerisce.
                                  //in realta la lambda la possiamo fornire come argomento
                                  //della Where. Abbiamo specificato che vogliamo filtrare tutte
                                  //le persone il cui Nome è Mario.
            foreach(var item in pers)
              Console.WriteLine(item.Denominazione());
            /*--Adesso vogliamo selezionare tutte le persone il cui cognome è Rossi,
            selezioniamo l'eta e ne facciamo la somma.*/  
            int sum = persone.Where(z=>z.Cognome=="Rossi")
                                .Select(z=>z.Eta)
                                .Sum();//Al posto di Sum() possiamo usare il resto degli
                                       //operatori di aggregazione
            Console.WriteLine(sum);  
            //Aggiungiamo Distinct() se ci sono valori duplicati ne prende uno soltanto
             int somma = persone.Where(z=>z.Cognome=="Rossi")
                                .Select(z=>z.Eta)
                                .Distinct()
                                .Sum();
            Console.WriteLine(somma);          
            try
            {         
                //Estrazione di singoli oggetti First e Last                   
                Persona p = persone.Where(z=>z.Cognome=="Rossi")
                                    .First();//First Extension Method genera un'eccezione
                                             //se non trova valori come FirstOrDefault().
                Console.WriteLine(p.Denominazione()); 
            }  
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
            try
            {                          
                Persona p = persone.Where(z=>z.Cognome=="Verdi")
                                    .Single(); //Single() ritorna un solo valore
                                               //genera un'eccezione
                                               //se trova righe duplicate.
                Console.WriteLine(p.Denominazione()); 
            }  
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
            try
            {         
               //Ordinare una lista con OrderBy.                  
                IEnumerable<Persona> p = persone.Where(z=>z.Cognome=="Rossi")
                                                .OrderBy(x=>x.Peso);
                                                 
                                               
                foreach (var item in p)
                    Console.WriteLine(item.Denominazione());             
                
            }  
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
            try
            {         
               //Raggruppare               
                var p = persone.GroupBy(p=>p.Cognome);;
                foreach(var item in p)
                {
                    foreach(var s in item)
                    {
                        Console.WriteLine(s.Denominazione());
                    }
                }                             
                                                 
            }  
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 

        }
    }
    public class Persona
    {
        private string nome;
        private string cognome;
        private int eta;
        private int altezza;
        private int peso;
        public string Nome
        {
            get => nome;
            set => nome=value;
        }
        public string Cognome
        {
            get => cognome;
            set => cognome=value;
        }
         public int Eta
        {
            get => eta;
            set => eta=value;
        }
        public int Altezza
        {
            get => altezza;
            set => altezza=value;
        }
        public int Peso
        {
            get => peso;
            set => peso=value;
        }
    }
    public static class Extension
    {
        public static string Denominazione(this Persona value)
             =>$"{value.Nome} {value.Cognome} {value.Eta}";
    }
   
}

