using System;
namespace InterfacesCasting
{
    interface IStorable
    {
        void Save();
        void Load();
        bool NeedsSave { get; set; }
    }
    class Document : IStorable
    {
        private string name;
        public Document(string s)
        {
            name = s;
            Console.WriteLine("Created a document with name: '{0}'", s);
        }
        public void Save()
        {
            Console.WriteLine("Saving the document");
        }
        public void Load()
        {
            Console.WriteLine("Loading the document");
        }
        public bool NeedsSave { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Document d = new Document("Test Document1");
            if (d is IStorable)
            {
                d.Save();
            }
            IStorable istorable = d as IStorable;
            if (istorable != null)
            {
                istorable.Load();
            }
            Console.WriteLine("\nPress Enter to continue....");
        }
    }
}