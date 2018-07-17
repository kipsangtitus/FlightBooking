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
        public static bool ReturnFlight { get; set; }

        //public static bool returnFlight = true? {"true";"false";}
       // public static string yes { get; set; }
       // public static string no { get; set; }



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
            Console.WriteLine("Enter Date And Time");
            DateTime = Convert.ToDateTime(Console.ReadLine());
            Console.Clear();

        }

        public static void display()
        {
            Console.WriteLine($"name: {Name}");
            Console.WriteLine($"Passport number: {Passportnumber}");
            Console.WriteLine($"Residence: {Residence}");
            Console.WriteLine($"Destination: {Destination}");
            Console.WriteLine($"Date and time{DateTime}");
        }
         
        public static void BookingReturnFlight()
        {
             
            Console.WriteLine("Would you wish to book a Return flight?:true or false");
            Flight.ReturnFlight = Convert.ToBoolean(Console.ReadLine());
            var returnflight = Flight.ReturnFlight == true ? "Yes" : "No";
            if (ReturnFlight)
            {
                Console.WriteLine("Enter return Date &Time");
                DateTime = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine(DateTime);
                Console.WriteLine("RETURN FLIGHT DETAILS");
                Console.WriteLine($"Origin:{Destination}");
                Console.WriteLine($"Destination:{Residence}");
                Console.WriteLine($"Date and Time{DateTime}");
                Console.WriteLine($"Passport Number:{Passportnumber}");
                
                Console.WriteLine("Thank you for using our services");
                
                
            }
            else
            {
                Console.WriteLine("NO RETURN FLIGHT");
                Console.WriteLine("Thank you for using our services");
            }
            

        }
    }
}