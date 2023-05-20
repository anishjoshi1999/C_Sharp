using System;
namespace Multiple_Interfaces
{
    interface IStorable
    {
        void Save();
        void Load();
        Boolean NeedsSave { get; set; }
    }
    interface IEncryptable
    {
        void Encrypt();
        void Decrypt();    
    }
    class Document: IStorable,IEncryptable
    {
        private string name;
        public Document(string s) {
            name = s;
            Console.WriteLine("Created a document with name '{0}'",s);
        }
        public void Save()
        {
            Console.WriteLine("Saving the document");
        }
        public void Load()
        {
            Console.WriteLine();
        }
        public Boolean NeedsSave { get; set; }   

        public void Encrypt()
        {
            Console.WriteLine("Encryting the document");
        }
        public void Decrypt()
        {
            Console.WriteLine("Decrypting the document");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Document d = new Document("Test Document");
            d.Load();
            d.Encrypt();
            d.Save();
            d.Decrypt();
            Console.WriteLine("\nPress Enter to continue....");
        }
    }

}