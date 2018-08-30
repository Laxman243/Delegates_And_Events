using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // defining the delegate
    public delegate void AddDelegate(int i, int j);
    public delegate void AddName(string s1);
    public delegate string AddJob(string s2);

    class Program
    {
        // Normal two methods i have defined in my class , now i want to call this methods
        // using delegates i am calling this methods 
        // lets see
       public  static void Add(int i, int j)
        {
            Console.WriteLine(i+j);
        }
        public void Name(string s)
        {
            Console.WriteLine(s);
        }
       public static string Job(string s)
        {
            return s;
        }
        static void Main(string[] args)
        {
            Program p = new Program();

            // create instance of delegates
            AddDelegate ad = new AddDelegate(Program.Add);
            AddName an = new AddName(p.Name);
            AddJob aj = new AddJob(Program.Job);// normal call also applicable , keeping Class Name by calling is optional 
            // in case of static methods

            // now call the delegate , by pass the value so that the method which is bound with delegate internally should execute
            ad(100, 200);
            ad.Invoke(2000,20200);
            an.Invoke("laxman");
            an("shukla");
            string s1 = aj("ved");
           string s = aj.Invoke("praksh");
            Console.WriteLine(s1);
            Console.WriteLine(s);
            Console.WriteLine("Complete");
            Console.Read();
        }
    }
}
namespace MultiCastDelegates
{
    // declare the delegates
    public delegate void AddColor(string s);
    class MultiDelegates
    {
        public void Color(string s)
        {
            Console.WriteLine(s);
        }
        public void Flower(string s)
        {
            Console.WriteLine(s);
        }
        public void Flowers(string s)
        {
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            MultiDelegates md = new MultiDelegates();

            // instantaiting the delegates
            // first way 
            // AddColor ac = new AddColor(md.Color);
            //ac.Invoke("laxman");

            // to bind two methods call use this way
            AddColor ac = md.Color;
            ac += md.Flower; ac += md.Flowers;
            ac.Invoke("redFlower");
            Console.WriteLine("completed");
            Console.Read();         
        }
    }
}
namespace AnonymousMethods
{
    // defining an delegates
    public delegate string AddStudents(string s);
    class AnonymousExample
    {
        // hide this method method you will get the output
      /*  public static string Student(string s)
        {
            return "Hello"  + " "+ s +" " + "Welcome to Bizruntime";
        }*/
        static void Main(string[] args)
        {
            //creating an instance to the delegates
            AddStudents a = delegate (string s)
            {
                return "Hello"+ " " + s +" " + "Welcome to Bizruntime";
            };
           string str =  a.Invoke("laxman");
            Console.WriteLine(str);
            Console.Read();
        }
    }
}