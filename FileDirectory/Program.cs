using System;
using System.IO;
using System.Threading.Tasks;

namespace FileDirectory
{
    class Program
    {
        static async Task Main(string[] args)
        {
            String file = await ReadWriteText();
            Console.WriteLine(file);
            GetDirectoryFiles();
            CopyDirectory();
            await ReadWriteBinaryFile();
        }
        //LETTURA E SCRITTURA DI UN FILE DI TESTO
        private static async Task<string> ReadWriteText()
        {
            string buffer;
            string output = null;
            try
            {
                using(StreamReader reader = File.OpenText(@"C:\Temp\input.txt"))
                {
                    using(StreamWriter writer = File.CreateText(@"C:\Temp\output.txt"))
                    {
                        while((buffer = await reader.ReadLineAsync())!=null)
                        {
                            writer.WriteLine(buffer);
                            output += buffer;
                        } 
                    }
                    return output;   
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null; 

            }
        }
        //LISTA DEI FILE IN UNA DIRECTORY
        private static void GetDirectoryFiles()
        {
            string path = @"C:\Temp";
            try
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                FileInfo[] files = directory.GetFiles("*.txt");
                foreach(var item in files)
                    Console.WriteLine(item);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }
        }
        //COPIARE UNA DIRECTORY
        private static void CopyDirectory()
        {
            try
            {
                DirectoryInfo source = new DirectoryInfo(@"C:\Temp2");
                DirectoryInfo destination = new DirectoryInfo(@"C:\Temp3");
                CopyDirectory(source,destination);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        static void CopyDirectory(DirectoryInfo source, DirectoryInfo destination)
        {
            try
            {
                if (!destination.Exists)
                {
                    destination.Create();
                }

                // Copia tutti i file
                FileInfo[] files = source.GetFiles();
                foreach (var file in files)
                    file.CopyTo(Path.Combine(destination.FullName,file.Name));
                // Processa le sottodirectory
                DirectoryInfo[] dirs = source.GetDirectories();
                foreach (DirectoryInfo dir in dirs)
                {
                    // Directory di destinazione 
                    //Path.Combine combina due stringhe in un unico pah.
                    string destinationDir = Path.Combine(destination.FullName, dir.Name);
                    // Richiama la funzione stessa ricorsivamente
                    CopyDirectory(dir, new DirectoryInfo(destinationDir));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
         }
         //SCRIVERE E LEGGERE UN FILE BINARIO
         private static async Task ReadWriteBinaryFile()
         {
             byte[] output = new byte[] {0x66, 0x67, 0x68, 0x69, 0x70,0x71,0x72, 0x73, 0x74, 0x75, 0x76,0x77};
             try
             {
                 //CANCELLARE UN FILE
                 if(File.Exists(@"C:\Temp\outputbinary.txt"))
                     File.Delete(@"C:\Temp\outputbinary.txt");
                //SCRIVERE 
                using(FileStream stream = new FileStream(@"C:\Temp\outputbinary.txt",FileMode.Create))
                {
                    await stream.WriteAsync(output,0,output.Length);
                }
                //LEGGERE
                using(FileStream stream = new FileStream(@"C:\Temp\outputbinary.txt",FileMode.Open))
                {
                    int count = 0;
                    int read;
                    byte[] buffer = new byte[output.Length];
                    while (count < output.Length)
                    {
                        read = await stream.ReadAsync(buffer, 0, output.Length);
                        Console.Write(Convert.ToChar(buffer.GetValue(count)) + " ");
                        count++;
                    }
                }
             }
             catch(Exception e)
             {
                 Console.WriteLine(e.Message);
             }
         }
    }
}
