using System;

namespace ConsoleApp7
{
    public class Flight
    {
        public static string Name { get; set; }
        public static int Passportnumber { get; set; }
        public static DateTime DateTime { get; set; }
        public static string Destination { get; set; }
        public static string Residence { get; set; }
        public static string Category { get; set; }
        public static int Amount { get; set; }
       
        
        public static void Input()
        {
            Console.WriteLine("Enter Name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Passport number");
            Passportnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Residence");
            Residence = Console.ReadLine();
            Console.WriteLine("Enter destination");
            Destination = Console.ReadLine();
            Console.WriteLine("Enter category");
            Category = Console.ReadLine();
        }

        public static void display()
        {
            Console.WriteLine($"name: {Name}");
            Console.WriteLine($"Passport number: {Passportnumber}");
            Console.WriteLine($"Residence: {Residence}");
            Console.WriteLine($"Destination: {Destination}");
        }
         
        public static void BookingReturnFlight()
        {
            
           
        }
    }
}