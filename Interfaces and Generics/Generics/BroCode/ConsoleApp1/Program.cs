using System;
class Program
{
    //"not specific" to a particular data type
    // and <T> to: classes,methods,fields, etc.
    // allows for code reusuability for different data types
     
    static void Main(string[] args)
    {
        int[] intArray = { 1, 2, 3, 4, 5 };
        double[] doubleArray = { 1.0, 2.0, 3.0 };
        String[] stringArray = { "1", "2", "3" };
        displayElements(intArray);
        displayElements(doubleArray);
        displayElements(stringArray);
    }

    public static void displayElements<Thing>(Thing[] array)
    {
        foreach (Thing element in array)
        {
            Console.Write(element + " ");
        }
            Console.WriteLine();
    }
}