using static System.Net.Mime.MediaTypeNames;

string searchTerm = "data";

//Convert the string into an array of words  
string[] source = text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);

// Create the query.  Use the InvariantCultureIgnoreCase comparision to match "data" and "Data"
var matchQuery = from word in source
                 where word.Equals(searchTerm, StringComparison.InvariantCultureIgnoreCase)
                 select word;

// Count the matches, which executes the query.  
int wordCount = matchQuery.Count();
Console.WriteLine("{0} occurrences(s) of the search term \"{1}\" were found.", wordCount, searchTerm);

// Keep console window open in debug mode  
Console.WriteLine("Press any key to exit");
Console.ReadKey();  
    }  
