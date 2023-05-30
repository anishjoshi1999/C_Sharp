using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Dictionary that maps strings to strings: (Key,value) pairs
            Dictionary<string, string> fileTypes = new Dictionary<string, string>();
            // Add some file type extensions and their descriptions
            fileTypes.Add(".txt", "Text File");
            fileTypes.Add(".htm", "HTML Web Page");
            fileTypes.Add(".html", "HTML Web Page");
            fileTypes.Add(".css", "Cascading Style Sheet");
            fileTypes.Add(".xml", "XML Data");

            // TODO: How many key/value pairs are there?
            Console.WriteLine("There are {0} key/value pairs\n",fileTypes.Count);
            // TODO: try adding an existing key
            try
            {
                fileTypes.Add(".htm", "Web Page");
            }
            catch(ArgumentException e)
            {
                Console.WriteLine("Key already exists");
            }

            // TODO: try removing and then finding a key
            fileTypes.Remove(".css");
            Console.WriteLine("fileTypes contains CSS: {0}\n",fileTypes.ContainsKey(".css"));
            // TODO: Dump the contents of the Dictionary
            Console.WriteLine("Dumping dictionary contents:");
            foreach(KeyValuePair<string, string> kvp in fileTypes)
            {
                Console.WriteLine("Key={0},Value={1}",kvp.Key,kvp.Value);
            }
            Console.WriteLine("\nHit Enter to continue...");
        }
    }
}