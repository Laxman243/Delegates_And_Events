using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate String CallDelegate(string s);
    public delegate string PhoneDelegate(string s1);
    class GenericExampleOnDelegates
    {
        public static string Call(string s)
        {
            return s;
        }
        public static string Phone(string s1)
        {
            return s1;
        }
        public int Number(int i, int j, int k)
        {
            return i + j + k;
        }
        static void Main(string[] args)
        {
            Func<string, string> obj = Call; obj += Phone;
            string s2 = obj.Invoke("Hello");
            Console.WriteLine(s2 );

            GenericExampleOnDelegates obj1 = new GenericExampleOnDelegates();
            Func<int, int, int, int> fn1 = obj1.Number;
            int num = fn1.Invoke(10, 20, 30);
            Console.WriteLine(num);
            Console.Read();
            
        }
    }
}
