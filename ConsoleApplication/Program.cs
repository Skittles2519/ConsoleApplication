using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Hunter";
            var location = "Idaho Falls";
            var date = DateTime.Now.Date.ToString("MM/dd/yyyy");
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am from {location}");
            Console.WriteLine($"Todays date is {date} which means there are ");


        }
    }
}
