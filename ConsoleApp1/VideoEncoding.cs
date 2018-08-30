using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //delegate Declaration
    public delegate void Encodedelegate(int x);
        
    class VideoEncoding
    {        
        public static void Encode(int i)
        {
            Console.WriteLine("Video is Encoding");
            //Thread.Sleep(5000);
        }
        public static void Encode1(int j)
        {
            Console.WriteLine("Video is Encoding " + j);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Any Digit TO Encode Video");
            int i = Convert.ToInt32(Console.ReadLine());
            Encodedelegate t;
            t = Encode;
            t += Encode1;
            t.Invoke(i);
            Notification obj = new Notification();
            obj.EventAction += UserA.Xhandler;
            obj.EventAction -= UserB.Yhandler;

            obj.NotifyOnCell(i);
            Console.ReadKey();

            
        }
    }
    class Notification
    {
        public event Encodedelegate EventAction;
        // Raising an Event
        public void NotifyOnCell(int x)
        {
            if (this.EventAction != null)
            {
                this.EventAction(x);
            }
        }
    }
    class UserA
    {
        public static void Xhandler(int x)
        {
            Console.WriteLine("notification recieved by userA object");
        }
    }
    class UserB
    {
        public static void Yhandler(int x)
        {
            Console.WriteLine("Notification recieved by userB object");
        }
    }
    
    
}
