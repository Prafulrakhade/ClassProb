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
        static void Main(string[] args)
        {
            string name1;
            name1 = TakeUsername();
            Console.WriteLine("Hello My Name is " + name1);
        }
    }
}
