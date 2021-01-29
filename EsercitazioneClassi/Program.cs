using System;

namespace EsercitazioneClassi
{
    class Program
    {
        static void Main(string[] args)
        {
            Utente utente1 = new Utente("1234560","Mario","Rossi","4356789");
            utente1.SetSaldo(13000m);
            Utente utente2 = new Utente("12345678","Mario","Verdi","435679879");
            utente2.SetSaldo(30000m);
            utente1.SaldoCorrente();
            utente2.SaldoCorrente();
            Banca b1 = new Banca("1234567890","UBI Banca",utente1);
            Banca b2 = new Banca("1234576543","UBI Banca",utente2);
            b1.Preleva(14000m);
            b2.Preleva(10000m);
            utente2.SaldoCorrente();
        }
    }
    internal class Utente
    {
             private string id;
             private string nome;
             private string cognome;
             private decimal saldo;
             private string numeroConto;

             public Utente(string id,string nome, string cognome, string numeroConto)
             {
                 this.id=id;
                 this.nome=nome;
                 this.cognome=cognome;
                 this.numeroConto=numeroConto;
             }
             internal void Denominazione()
             {
                 Console.WriteLine($"Utente {this.nome + " " +this.cognome} numero di conto: {this.numeroConto}");
             }
             internal void SaldoCorrente()
             {
                 Console.WriteLine($"Utente {this.nome + " " +this.cognome} saldo corrente: {this.GetSaldo()}");
             }
             internal decimal GetSaldo()
             {
                 return this.saldo;
             }
             internal void SetSaldo(decimal importo)
             {
                 if(importo<0)
                 {
                     Console.WriteLine($"Hai impostato un saldo negativo. Utente:{this.nome + " " + this.cognome}");
                     return;
                 }
                 this.saldo=importo;
             }
    }
    internal class Banca
    {
            private string id;
            private string denominazione;
            private string abi;
            private string cab;
            private Utente utente;
            public Banca(string id, string denominazione,Utente utente,string abi, string cab)
            {
                this.id=id;
                this.denominazione=denominazione;
                this.utente=utente;
                this.abi=abi;
                this.cab=cab;
            }
            public Banca(string id,string denominazione,Utente utente):this(id,denominazione,utente,"06098","14400"){}

            internal void Denominazione()
            {
                Console.WriteLine($"Id Banca {this.id} ,denominazione: {this.denominazione}");
            }
            internal void Preleva(decimal importo)
            {
                decimal saldo = utente.GetSaldo();
                if(importo>saldo)
                {
                    Console.WriteLine($"Scoperto: Operazione di prelievo non ammessa, importo richiesto {importo}");
                    utente.Denominazione();
                    return;
                }
                if(importo<0)
                {
                    Console.WriteLine($"Importo prelevato non valido: {importo}");
                    return;
                }
                utente.SetSaldo(utente.GetSaldo()-importo);
                return;

            }
            internal void Accredito(decimal importo)
            {
                 if(importo<0)
                {
                    Console.WriteLine($"Importo accreditato non valido: {importo}");
                    utente.Denominazione();
                    return;
                }
                utente.SetSaldo(utente.GetSaldo()+importo);
                return;
            }
            
    }
}
