using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "Hunter";
            var location = "Idaho Falls";
            var now = DateTime.Now.Date;
            DateTime christmas = new DateTime(2020,12,25);
            var date = DateTime.Now.Date.ToString("MM/dd/yyyy"); 
            double daysleft = christmas.Subtract(now).TotalDays;
            Console.WriteLine($"My name is {name}");
            Console.WriteLine($"I am from {location}");
            if (daysleft > 1)
            {
                Console.WriteLine($"Todays date is {date} which means there are {daysleft} days left until Christmas.");
            }
            else
            {
                Console.WriteLine($"Todays date is {date} which means there is 1 day left until Christmas.");
            }
            Console.WriteLine("Before you leave, enter a number");



            double width, height, woodLength, glassArea;
            string widthString, heightString;
            widthString = Console.ReadLine();
            width = double.Parse(widthString);
            Console.WriteLine("Awesome, now 1 more");

            heightString = Console.ReadLine();
            height = double.Parse(heightString);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);
            Console.WriteLine("The length of the wood is " +
            woodLength + " feet");
            Console.WriteLine("The area of the glass is " +
            glassArea + " square meters");





        }
    }
}
