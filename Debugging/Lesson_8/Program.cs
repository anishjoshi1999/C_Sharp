using System.Text;

namespace Lesson_8
{
    class Program
    {
        static int doubler(int x)
        {
            return x * x;
        }
        static string addGenericLastName(String name)
        {
            return name + " Joshi";
        }
        static void Main(String[] args) {
            doubler(3);
            String name = "Anish";
            string newName = addGenericLastName(name);
            Console.WriteLine(newName);
        }
    }
}