using System;
using System.Collections.Generic;

namespace CollectionGeneriche
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("***************************************************************");
            Console.Write("\n");
            Console.WriteLine("LIST<T>"); 
            //LIST<T>
            //Aggiungo elementi usando metodo Add
            List<string> city = new List<string>();
            city.Add("Milano");
            city.Add("Torino");
            city.Add("Roma");
            string[] bigCity = new []{"New York","London","Chicago"};
             //Aggiungo elementi usando metodo AddRange
            city.AddRange(bigCity);
            //Aggiungo elementi usando la collection-initializer syntax
            List<string> city1 = new List<string>(){"Napoli,Firenze,Perugia"};
            //Accedo agli elementi con gli indici, si può usare la struttura Index
            string prima = city[0];
            string ultima = city[^1];
            Console.Write($"{prima} {ultima} ");
            Console.Write("\n");
            //Seleziono le prime 4 citta
            string[] arr = city.ToArray()[0..4];
            foreach (var item in arr)
                Console.Write(item + " ");
            Console.Write("\n");    
            //scorro con linq tutte le città
            city.ForEach(c => Console.Write(c +" ")); 
            Console.Write("\n");   
            List<Person> person = new List<Person>(){
                new Person(){Id=1,Nome="Mario",Cognome="Rossi"},
                new Person(){Id=2,Nome="Mario",Cognome="Verdi"},
                new Person(){Id=3,Nome="Mario",Cognome="Bianchi"}
            };  
            Person p = person.Find(x=>x.Cognome=="Rossi");
            if(p!=null)
               Console.WriteLine(p.Id);
            List<Person> p1 = person.FindAll(x=>x.Nome=="Mario");
            List<int> num = new List<int>(){5,10,15,20};
            //Remove element from list
            num.Remove(5);//rimuove il 5
            num.RemoveAt(1);//rimuove il numero di indice 1 cioè 15 (based zero index)
            //Check item
            Console.WriteLine(num.Contains(5));
            Console.WriteLine(num.Contains(10));
            //Inserimento all'indice specificato
            num.Insert(2,15);
            num.Sort();
            num.ForEach(n=>Console.Write(n + " "));
            Console.Write("\n");
            Console.Write("***************************************************************");
            Console.Write("\n");
            Console.WriteLine("QUEUE<T>"); 
            //QUEUE<T>
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(33);
            while(queue.Count > 0)
                 Console.Write(queue.Dequeue() + " ");//Dequeue rimuove gli elementi dalla collection
                                                    //se non vogliamo rimuovere gli elementi si usa
                                                    //il metodo Peek().
            Console.Write("\n");  
            Console.Write(queue.Count); 
            Console.Write("\n");                                     
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);  
            Console.Write(queue.Peek());
            Console.Write("\n");  
            Console.Write(queue.Count); 
            Console.Write("\n"); 
            Console.Write("***************************************************************");
            Console.Write("\n");
            Console.WriteLine("STACK<T>"); 
            //STACK<T>
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            while(myStack.Count > 0)
                Console.Write(myStack.Pop() + " ");
            Console.Write("\n"); 
            Console.Write(myStack.Count); 
            Console.Write("\n"); 
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            Console.Write(myStack.Peek());
            Console.Write("\n"); 
            Console.Write(myStack.Count); 
            Console.Write("\n");
            //DICTIONARY<TKey, TValue>
            Console.Write("***************************************************************");
            Console.Write("\n");
            Console.WriteLine("DICTIONARY<TKey, TValue>");
            IDictionary<int, string> number = new Dictionary<int, string>();
            number.Add(1,"uno"); //adding a key/value using the Add() method
            number.Add(2,"due");
            number.Add(3,"tre");
            foreach (KeyValuePair<int,string> k in number)
                Console.Write($"Key: {k.Key} Value: {k.Value} ");
            Console.Write("\n");    
            //creating a dictionary using collection-initializer syntax   
            var ps = new Dictionary<int,Person>(){
                {1,new Person(){Id=1,Nome="Mario",Cognome="Rossi"}},
                {2,new Person(){Id=2,Nome="Luigi",Cognome="Verdi"}},
                {3,new Person(){Id=3,Nome="Paolo",Cognome="Bianchi"}}

            };                
            foreach (KeyValuePair<int,Person> k in ps)
              Console.Write($"Key: {k.Key} Value: {k.Value.Cognome} ");
            Console.Write("\n");   
            if(ps.ContainsKey(1))
              Console.Write("Contains Key " + ps[1].Id + " " + ps[1].Nome + " " + ps[1].Cognome);
            Console.Write("\n");    
            //usare TryGetValue() per restituire un valore di una chiave sconosciuta.
            Person person1;
            if(ps.TryGetValue(4,out person1))
                Console.Write(p.Id);
            //Update
            ps[1] = new Person(){Id=4,Nome="Susanna", Cognome="Rossi"};
            //Remove Element
            if(ps.ContainsKey(3))
                ps.Remove(3);     
            foreach (KeyValuePair<int,Person> k in ps)
              Console.Write($"Key: {k.Key} Value: {k.Value.Id + " " +k.Value.Nome + " " + k.Value.Cognome} ");
            Console.Write("\n"); 
            ps.Clear();//Rimuove tutto chiavi e valori. 
             //SORTEDLIST<TKey, TValue>
            Console.Write("***************************************************************");
            Console.Write("\n");
            Console.WriteLine("SORTEDLIST<TKey, TValue>"); 
            SortedList<int,string> numbers = new SortedList<int, string>(){
                             {1,"uno"},
                             {5,"cinque"},
                             {3,"tre"}
            };
            numbers.Add(2,"due");
            numbers.Add(4,"quattro");
            numbers.Add(6,"sei");
            string ultimo = numbers[6]; //Accesso al valore
            numbers[3]="TRE";//Update
            Console.Write("\n");   
            string result;
            if(numbers.TryGetValue(4, out result))
                Console.WriteLine("TryGetValue Key: {0}, TryGetValue Value: {1}", 4, result); 
            Console.Write("\n"); 
            numbers.Remove(1);
            numbers.RemoveAt(0); 
            foreach(var item in numbers)
               Console.Write($"Key : {item.Key} value: {item.Value} ");//Ordine crescente di chiave          
        }
    }
    public class Person
    {
        private int id;
        private string nome;
        private string cognome;
        public int Id
        {
            get => id;
            set => id = value;
        }
        public string Nome
        {
            get => nome;
            set => nome = value;
        }
        public string Cognome
        {
            get => cognome;
            set => cognome = value;
        }
    }
}
