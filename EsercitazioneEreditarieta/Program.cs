using System;
 
namespace EsercitazioneEreditarieta
{
    class Program
    {
        static void Main(string[] args)
        {
            Utente utente1 = new Utente("1234560","Mario","Rossi","4356789");
            utente1.Saldo = 13000m;
            Utente utente2 = new Utente("12345678","Mario","Verdi","435679879");
            utente2.Saldo = 30000m;
            utente1.SaldoCorrente();
            utente2.SaldoCorrente();
            Banca b1 = new Banca("1234567890","UBI Banca",utente1);
            Banca b2 = new Banca("1234576543","UBI Banca",utente2);
            b1.Preleva(14000m);
            b2.Preleva(10000m);
            utente2.SaldoCorrente();
        }
    }
    internal class Persona
    {
             public string Nome {get;set;}
             public string Cognome {get;set;}
 
             public string Denominazione
             {
                  
                 get{
                     return "Utente " + this.Nome + " " + this.Cognome;
                 }
                 
             }
    }
    internal class Utente : Persona
    {
             private decimal saldo;
             public string Id {get;set;}
             
             public decimal Saldo
             {
                 get{
                     return this.saldo;
                 }
                 set{
                     if(value<0)
                        Console.WriteLine($"Impossibile impostare il saldo. Valore passato: {value}");
                     else
                        this.saldo=value;
                 }
            }   
 
             public string NumeroConto {get;set;}
 
             public Utente(string id,string nome, string cognome, string numeroConto)
             {
                 this.Id=id;
                 this.Nome=nome;
                 this.Cognome=cognome;
                 this.NumeroConto=numeroConto;
             }
             internal void SaldoCorrente()
             {
                 Console.WriteLine($"Utente {this.Nome + " " +this.Cognome} saldo corrente: {this.Saldo}");
             }
    }
    internal class Banca
    {
            public string Id {get;set;}
            public string Denominazione {get;set;}
            public string Abi {get;set;}
            public string Cab {get;set;}
            public Utente Utente {get;set;}
            public Banca(string id, string denominazione,Utente utente,string abi, string cab)
            {
                this.Id=id;
                this.Denominazione=denominazione;
                this.Utente=utente;
                this.Abi=abi;
                this.Cab=cab;
            }
            public Banca(string id,string denominazione,Utente utente):
            this(id,denominazione,utente,"06098","14400"){}
 
            internal void Preleva(decimal importo)
            {
                decimal saldo = Utente.Saldo;
                if(importo>saldo)
                {
                    Console.WriteLine($"Operazione di prelievo non ammessa, importo richiesto {importo}");
                    return;
                     
                }
                if(importo<0)
                {
                    Console.WriteLine($"Importo prelevato non valido: {importo}");
                    return;
                }
                Utente.Saldo = Utente.Saldo - importo;
                return;
 
            }
            internal void Accredito(decimal importo)
            {
                if(importo<0)
                {
                    Console.WriteLine($"Importo accreditato non valido: {importo}");
                    return;
                }
                Utente.Saldo = Utente.Saldo +importo;
                return;
            }    
    }
}    
