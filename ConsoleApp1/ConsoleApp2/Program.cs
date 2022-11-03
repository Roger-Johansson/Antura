//Count words in empty file.

//Count words in file without spaces between words.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;


namespace ConsoleApp2
{
    internal class Program

    {

        // Default folder   
        //static readonly string rootFolder = @ "C:\Temp\Data\";
        //Default file. MAKE SURE TO CHANGE THIS LOCATION AND FILE PATH TO YOUR FILE  

        static readonly string textFile = "European languages are.txt";
        static int Main(string[] args)
        {
            // Test if input arguments were supplied:
            if (args.Length == 0)
            {
                System.Console.WriteLine("Please enter a file name.");
                System.Console.WriteLine("Example usage: ConsoleApp1 myfile.txt");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
            //if (File.Exists(textFile))
            //{

            //    // Read entire text file content in one string
            //    string text = File.ReadAllText(textFile);
            //    Console.WriteLine(text);
            //}

            //if (File.Exists(textFile))
            //{
            //    // Read a text file line by line. 
            //    string[] lines = File.ReadAllLines(textFile);
            //    foreach (string line in lines)
            //        Console.WriteLine(line);
            //}

            if (File.Exists(textFile))
            {
                // Read a text file line by line. 
                string lines = File.ReadAllText(textFile);
                string searchterm = Path.GetFileNameWithoutExtension(textFile);
                int count = Regex.Matches(lines, searchterm).Count;
                Console.WriteLine(count);
            }

            //if (File.Exists(textFile))
            //{
            //    // Read a text file line by line. 
            //    string text = File.ReadAllText(textFile);
            //    string searchTerm = "European";

            //    //Convert the string into an array of words  
            //    string[] source = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

            //    // Create the query.  Use the InvariantCultureIgnoreCase comparision to match "data" and "Data"
            //    var matchQuery = from word in source
            //                     where word.Equals(searchTerm, StringComparison.InvariantCultureIgnoreCase)
            //                     select word;

            //    // Count the matches, which executes the query.  
            //    int wordCount = matchQuery.Count();
            //    Console.WriteLine("{0} occurrences(s) of the search term \"{1}\" were found.", wordCount, searchTerm);

            //    // Keep console window open in debug mode  
            //    Console.WriteLine("Press any key to exit");
            //    Console.ReadKey();
            //}

            //if (File.Exists(textFile))
            //{
            //    // Read file using StreamReader. Reads file line by line 
            //    using StreamReader file = new(textFile);
            //    int counter = 0;
            //    string ln;
            //    while ((ln = file.ReadLine()) != null)
            //    {
            //        Console.WriteLine(ln);
            //        counter++;
            //    }

            //    file.Close();
            //    Console.WriteLine($"File has {counter} lines.");
            //}
            Console.ReadKey();
            

            return 0;
        }
    }
}
