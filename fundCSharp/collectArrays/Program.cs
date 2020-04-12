using System;

namespace collectArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            // List all of the days in the week 
            // foreach (string day in daysOfWeek)
            // {
            //     Console.WriteLine(day);
            // }
            System.Console.WriteLine("Which day do you want to display?");
            Console.Write("Monday = 1, etc. > ");
            int iDay = int.Parse(Console.ReadLine());

            string chosenDay = daysOfWeek[iDay];
            System.Console.WriteLine($"That day is {chosenDay}");
        }
    }
}
