using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProgrammazioneAsincrona
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int result = await DownloadAsync();
            Console.WriteLine($"Lunghezza stringa: {result}");
            IndependentWork();
            await ParallelMethod();
        }
        //METODO ASINCRONO
        private static async Task<int> DownloadAsync()
        {
            /*Metodo asincrono. In condizioni normali, dovremmo in qualche modo gestire il callback su questo oggetto 
            per recuperare l’informazione prelevata dalla rete; grazie alla parola chiave await, 
            invece, è il compilatore stesso a preoccuparsi di iniettare tutto il codice necessario, 
            e noi possiamo semplicemente limitarci a prelevare il risultato dell’esecuzione asincrona.
            Il Thread non resta bloccato.*/
            Console.WriteLine("Async Download");
            WebRequest client = HttpWebRequest.Create("https://www.google.com");
            var response = client.GetResponse();
            using(var reader = new StreamReader(response.GetResponseStream()))
            {
                var result = await reader.ReadToEndAsync();
                return result.Length;
            }
        }
        //METODO SINCRONO
        private static int Download()
        {
            /*--Metodo sincrono. Fintanto che il risultato non viene recuperato, il thread resta bloccato e in attesa.*/
            Console.WriteLine("Download");
            WebRequest client = HttpWebRequest.Create("https://www.google.com");
            var response = client.GetResponse();
            using(var reader = new StreamReader(response.GetResponseStream()))
            {
                var result = reader.ReadToEnd();
                Console.WriteLine(result);
                return result.Length;
            }
        }
        private static void IndependentWork() => Console.WriteLine("Meotodo IndependentWork()....");
        private static async Task ParallelMethod()
        {
            /*In questo caso, abbiamo evitato di utilizzare await in corrispondenza di 
            ogni singola chiamata, memorizzando le istanze dei Task<string> restituite 
            all’interno della lista tasks. Il risultato è che il flusso del codice non 
            viene più interrotto per attendere i risultati e le operazioni vengono effettivamente 
            avviate in parallelo. Per recuperare poi i risultati, dobbiamo attendere 
            il completamento di tutte le chiamate asincrone, effettuando un await sul metodo
            WhenAny della classe, come mostrato nel codice.*/
            Console.WriteLine("Parallel operations");
            HttpClient client = new HttpClient();
            Task<string> task1 = client.GetStringAsync("http://www.google.com");
            Task<string> task2 = client.GetStringAsync("http://www.bing.com");
            Task<string> task3 = client.GetStringAsync("http://www.yhaoo.com");
            var tasks = new List<Task> { task1, task2, task3 };
            while (tasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(tasks);
                if (finishedTask == task1)
                {
                    Console.WriteLine($"Google numero caratteri nella pagina: {task1.Result.Length}");
                }
                else if (finishedTask == task2)
                {
                    Console.WriteLine($"Bing numero caratteri nella pagina: {task2.Result.Length}");
                }
                else if (finishedTask == task3)
                {
                    Console.WriteLine($"Yhaoo numero caratteri nella pagina: {task3.Result.Length}");
                }
                tasks.Remove(finishedTask);
            }
        }  
    }
}