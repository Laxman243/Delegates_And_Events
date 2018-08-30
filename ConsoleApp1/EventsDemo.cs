using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void Transformer(int x);
    class EventsDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int i = Convert.ToInt32(Console.ReadLine());

            Transformer t; // create the insatnce
            t = Square;   //point to the function

            t += Cuber;  //two methods till now

            t.Invoke(i); //invoking the delegates

            NotificationMethods obj = new NotificationMethods();
            obj.transformerEvent += User1.Xhandler;
            obj.transformerEvent += User2.Yhandler;

            obj.NotifyOnCell(i);

            Console.ReadLine();
        }
        static void Square(int x)
        {
            Console.WriteLine(x * x);
        }
        static void Cuber(int x)
        {
            Console.WriteLine(2 * (x + x));
        }
    }
    class NotificationMethods   
    {
        public event Transformer transformerEvent; // reference for the delegate transformerEvent

        public void NotifyOnCell(int x)
        {
            if(transformerEvent != null)
            {
                transformerEvent(x);
            }
        }
    }
    
    // Two Subscriber User1 and User2 
    class User1
    {
        public static void Xhandler(int x)
        {
            Console.WriteLine("notification recieved by user1 object");
        }
    }
    class User2
    {
        public static void Yhandler(int y)
        {
            Console.WriteLine("Notification recieved by user2 object");
        }
    }
}
