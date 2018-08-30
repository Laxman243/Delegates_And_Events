using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void RunDelegate();
    public delegate void RunSlowDelegate(string s);
    class ExamplesOnDelegate
    {
        public void Run()
        {
            Console.WriteLine("From Run");
        }
        public void RunFast()
        {
            Console.WriteLine("From RunFast");
        }
        public static void Main()
        {
            ExamplesOnDelegate obj = new ExamplesOnDelegate();
            RunDelegate obj1 = () => {
                Console.WriteLine("Using Lamda Exprssion calls");
            };
             obj1 += obj.RunFast; obj1 += obj.Run;
            obj1.Invoke();

            RunSlowDelegate obj2 = (string s) =>
               {
                   
                   Console.WriteLine("Lamda Expression");
               };
            obj2.Invoke("helo");
            
            Console.WriteLine("Example Completed");
            Console.ReadKey();
        }
    }
}
