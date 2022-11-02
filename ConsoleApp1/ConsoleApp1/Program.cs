using System;
using System.IO;
using System.Text;
namespace ConsoleApp1
{
    /*
    1. pass argument to ConsoleApp1. File in same folder as ConsoleApp1. only .txt?
    2. Ok file? Retry or continue
    3. Read the file as one string.
        string text = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\WriteText.txt");
    4. Get the file name by removing file extension from args. Something in Linq?
        Path.GetFileNameWithoutExtension
    5. var count = source.Count(c => c == 'file name');  //will get even file names with spaces
    using System.Linq;
    6. Present result
    7. Close file?
    */
    class Program
    {
        public static string[] args;
        Program(string[] args)
        {
            Program.args = args;
        }
        private void Run()
        {
            var f = File.Open(args[0], FileMode.Open);  // opens file using first of arguments
            int pos = args[0].IndexOf('.');             // gets position of dot before file extension
            string name = args[0].Substring(0, pos);    // gets file name
            System.IO.StreamReader file = new System.IO.StreamReader(f); // create streamreader object
            string line;
            int counter = 0;
            while (true)
            {
                line = file.ReadLine();
                if (line == null) break;
                if (line.Contains(name))  // only finds first instance
                    counter++;
            }
            Console.WriteLine("found " + counter);
        }
        static void Main(string[] args)
        {
            Program program = new Program(args);
            program.Run();
        }
    }
}