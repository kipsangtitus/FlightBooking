using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Flight Titus=new Flight();
            Flight.Input();
            Console.Clear();
            Flight.display();
            
            Console.ReadKey();
        }
    }
}