using System;

namespace Eventi
{
    class Program
    {
        static Utente utente;
        static Banca banca;
        static void Main(string[] args)
        {
            utente = new Utente("1234560","Mario","Rossi","4356789");
            Program p = new Program();
            utente.NewSaldo += p.SaldoHandler;//SOTTOSCRIZIONE EVENTO
            utente.Saldo = 13000m;
            utente.SaldoCorrente();
            banca = new Banca("1234567890","UBI Banca",utente);
            banca.Preleva(8000m);
        }
        /*--GESTIONE DELL'EVENTO NewSaldo. IL METODO DEVE AVERE UNA SIGNATURE
        COMPATIBILE CON IL DELEGATE ACTION DEFINITO NELLA CLASSE UTENTE.*/
        public void SaldoHandler(decimal saldo)
        {
           Console.WriteLine($"Saldo utente {utente.Denominazione} è cambiato. Nuovo valore: {utente.Saldo}");       
        }
    }
    internal class Utente
    {
        public event Action<decimal> NewSaldo;//DEFINIZIONE DI UN EVENTO
        public void OnNewSaldo(decimal saldo)
        {
            if(NewSaldo!=null) //SE NON CI SONO ASCOLTATORI REGISTRATI NewSaldo VALE NULL.
                NewSaldo(saldo);//EMETTO L'EVENTO A TUTTI I SOTTOSCRITTORI.
        }
        private decimal saldo;
        public string Id {get;set;}
        public string Nome {get;set;}
        public string Cognome {get;set;}
        public decimal Saldo
        {
            get{
                    return this.saldo;
                }
            set{
                if(value<0)
                    Console.WriteLine($"Impossibile impostare il saldo. Valore passato: {value}");
                else
                {
                    this.saldo=value;
                    OnNewSaldo(value);//SE VIENE CAMBIATO IL SALDO EMETTO L'EVENTO SE CI SONO
                                          //DEI LISTNER ATTIVI.
                }
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
        public string Denominazione
        {
                 
            get{
                return "Utente " + this.Nome + " " + this.Cognome;
            }
                
        }
        internal void SaldoCorrente()
        {
            Console.WriteLine($"Utente {this.Nome + " " +this.Cognome} saldo: {this.Saldo}");
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


