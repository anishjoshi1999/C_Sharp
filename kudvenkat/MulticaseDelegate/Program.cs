using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MulticaseDelegate
{
    public delegate int SampleDelegate();
    class Program
    {
        static void Main(string[] args)
        {
            //SampleDelegate del1, del2, del3, del4;
            //del1 = new SampleDelegate(SampleMethod1);
            //del2 = new SampleDelegate(SampleMethod2);
            //del3 = new SampleDelegate(SampleMethod3);
            //del4 = del1 + del2 + del3;
            //del4();
            SampleDelegate del = new SampleDelegate(SampleMethod1);
            del += SampleMethod2;
            Console.WriteLine(del());

            del();
        }
        public static int SampleMethod1()
        {
            return 1;
        }
        public static int SampleMethod2()
        {
            return 2;
        }
        public static void SampleMethod3()
        {
            Console.WriteLine("Sample Method Three");
        }
    }
}
