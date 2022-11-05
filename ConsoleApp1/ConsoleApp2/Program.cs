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
        /*
         This program counts the occurences of a given text file name in the given text file contents.
         Example: searches the myFile.txt for occurences of myFile.
         Written by: Roger Johansson
         2022-11-06
        */
        static int Main(string[] args)
        {
            // Check if an input argument was given
            if (args.Length == 0)
            {
                System.Console.WriteLine("Please enter a file name.");
                System.Console.WriteLine("Example usage 1: ConsoleApp1 myfile.txt");
                System.Console.WriteLine("Example usage 2: ConsoleApp1 \"my file.txt\"");
                System.Console.WriteLine("NOTE! Place text file in the same folder as ConsoleApp.exe.");
                return 1;
            }
  
            // Check if given argument is an existing file name
            if (args.Length != 0 && !File.Exists(args[0]))
            {
                System.Console.WriteLine("Please enter a valid file name.");
                System.Console.WriteLine("NOTE! Place text file in the same folder as ConsoleApp.exe.");
                return 1;
            }
            
            // Read a text file, count instances of filename in the file contents, and present result
            string text = File.ReadAllText(args[0]);
            string searchterm = Path.GetFileNameWithoutExtension(args[0]);
            int count = Regex.Matches(text, searchterm).Count;
            Console.WriteLine($"The file {searchterm}.txt contains {count} instances of {searchterm}.");
            Console.WriteLine("Press any key to exit");
            // wait for user key press
            Console.ReadKey();
            
            return 0;
        }
    }
}
