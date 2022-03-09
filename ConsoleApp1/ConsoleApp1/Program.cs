using System;

namespace ConsoleApp1
{
    public class Program
    {
     
        public static string TakeUsername()
        {
            string name;
            Console.Write("enter the user Name : ");
            name = Console.ReadLine();
            return name;
        }
        public static int TakeUserAge()
        {
            int age;
            Console.Write("enter the user Age : ");
            age = Convert.ToInt32(Console.ReadLine());
            return age;
        }
        public static string userLocation()
        {
            string location;
            Console.Write("enter user Location : ");
            location = Console.ReadLine();
            return location;
        }
        static void Main(string[] args)
        {
            string name1;
            name1 = TakeUsername();
           // Console.WriteLine("Hello My Name is " + name1);
            int age1;
            age1 = TakeUserAge();
           // Console.WriteLine("And My Age Is "+ age1 );
            string location1;
            location1 = userLocation();
            Console.WriteLine(" Hello My Name is " + name1 + " And My Age Is "+ age1 + " I'm From " + location1);
        }
    }
}
