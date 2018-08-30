using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Normal Delegates implementation see generics Implementation in GENERICSEXAMPLES2 Programs
    public delegate double AddNumsDelegate(int i, float j, int k);
    public delegate void NamesDelegate(string s);
    public delegate bool DecisionsDelegates(string s1);
    class GenericDelegates
    {
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
            if(s1.Length < 4)
            return true;
            else
                return false;
        }
        static void Main(string[] args)
        {
            AddNumsDelegate obj1 = AddNums;
            double b = obj1.Invoke(100, 3.9f, 200);
            Console.WriteLine(b);

            NamesDelegate obj2 = Names;
            obj2.Invoke("laxman");

            DecisionsDelegates obj3 = Decision;
            bool t = obj3.Invoke("laxman");
            Console.WriteLine(t);
            Console.Read();


        }
    }
}
