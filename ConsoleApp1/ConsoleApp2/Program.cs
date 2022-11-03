//Count words in empty file.

//Count words in file without spaces between words.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
    internal class Program

    {

        // Default folder   
        //static readonly string rootFolder = @ "C:\Temp\Data\";
        //Default file. MAKE SURE TO CHANGE THIS LOCATION AND FILE PATH TO YOUR FILE  

        static readonly string textFile = "mytext.txt";
        static int Main(string[] args)
        {
            if (File.Exists(textFile))
            {

                // Read entire text file content in one string
                string text = File.ReadAllText(textFile);
                Console.WriteLine(text);
            }

            if (File.Exists(textFile))
            {
                // Read a text file line by line. 
                string[] lines = File.ReadAllLines(textFile);
                foreach (string line in lines)
                    Console.WriteLine(line);
            }

            if (File.Exists(textFile))
            {
                // Read a text file line by line. 
                string[] lines = File.ReadAllLines(textFile);
                var count = lines.Count(c => c == "mytext");
            }

            if (File.Exists(textFile))
            {
                // Read file using StreamReader. Reads file line by line 
                using StreamReader file = new(textFile);
                int counter = 0;
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    Console.WriteLine(ln);
                    counter++;
                }

                file.Close();
                Console.WriteLine($"File has {counter} lines.");
            }
            Console.ReadKey();
            
            // Test if input arguments were supplied:
            if (args.Length == 0)
            {
                System.Console.WriteLine("Please enter a numeric argument.");
                System.Console.WriteLine("Usage: Factorial <num>");
                return 1;
            }
            return 0;
        }
    }
}
