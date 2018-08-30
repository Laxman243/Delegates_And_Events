using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class GenericExample2
    {
        /*
        public static double AddNums(int i, float j, int k)
        {
            return i + j + k;
        }
        public static void Names(string s)
        {
            Console.WriteLine(s);
        }
        public static bool Decision(string s1)
        {
            if (s1.Length < 4)
                return true;
            else
                return false;
        }*/
        static void Main(string[] args)
        {
            /*
            Func<int, float, int, double> obj1 = AddNums;
            double b = obj1.Invoke(100, 3.9f, 200);
            Console.WriteLine(b);

            Action<string> obj2 = Names;
            obj2.Invoke("laxman");

            Predicate<string> obj3 = Decision;
            bool t = obj3.Invoke("laxman");
            Console.WriteLine(t);
            */
            // second way using Anonymous classes
            Func<int, float, int, double> obj1 = (x, y, z) =>
            {
                return x + y + z;
            };
            double b = obj1.Invoke(100, 3.9f, 200);
            Console.WriteLine(b);

            // Lamda example
            Action<string> obj2 = (s) => Console.WriteLine("hello");
            obj2.Invoke("laxman");

            Predicate<string> obj3 = (str) =>
            {
                if (str.Length > 4)
                    return true;
                else
                    return false;
            };
            bool t = obj3.Invoke("laxman");
            Console.WriteLine(t);

            Console.Read();


        }
    }
}
