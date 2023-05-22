namespace AnonymousDelegates
{
    class Program
    {
        public delegate string MyDelegate(int arg1,int arg2);   
        static void Main(string[] args)
        {
            //TODO: Implement an anonymous delegate
            MyDelegate f = delegate (int arg1, int arg2) {
            return (arg1 + arg2).ToString();
            };
            Console.WriteLine("The result is "+ f(10,20));
        }
    }
}