using System;
//There are two types of Types
//Value Types (int,float,double,structs,enums etc)
//Reference Types (Interface,Class,delegates,arrays etc)
//Reference Types can have null values

//By default value types are non nullable.
// int i = 0 (i is non nullable so we cannot set to null, i = null will generate compiler error)
// int ? j = 0 (j is nullable int , so j = null is legal)




class Program
{
    public static void Main(string[] args)
    {
        // i is a non nullable data types
        int? i = null;
        bool? AreYouMajor = null;
        if(AreYouMajor == true)
        {
            Console.WriteLine("User is Major");
        }else if(AreYouMajor == false)
        {
            Console.WriteLine("User is not Major");
        }else
        {
            Console.WriteLine("User didnot answer the questions");
        }

    }
}