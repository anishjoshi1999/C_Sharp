using System;

class Program
{
    static void Main(string[] args)
    {
        int total = 0;

       // non-generic ArrayList can hold any object
       // ArrayList arrList = new ArrayList();
      
       // arrList.Add("four");
       List<int> arrList = new List<int>();
        arrList.Add(1);
        arrList.Add(2);
        arrList.Add(3);
        // arrList.Add("four");
        // TODO: We can tell a Generic List what to hold

        foreach (int i in arrList)
        {
            total += i;
        }
        Console.WriteLine("The total is {0}\n\n", total);

        Console.WriteLine("Press Enter to continue");
        Console.ReadLine();
    }
}