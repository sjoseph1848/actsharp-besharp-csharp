/*
Write a prgram that reads data into an array of type int. Valid values are from 0 to 10.
Your program should display how many valid values were inputted as well as the number of invalid entries. 
Output a list of distinct valid entries and a count of how many times that entry occurred. 
Use the following test dat:
1 7 2 4 2 3 8 4 6 4 4 7
*/

using System;

namespace distinctArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            TestArray arr = new TestArray();
            Console.WriteLine($"Number of elements: {arr.NumberOfElements.ToString()}");
            Console.WriteLine($"Number of valid entries: {arr.ValidEntries()}");
            Console.WriteLine($"Number of invalid entries: {arr.NumberOfElements - arr.ValidEntries()}");
        }
    }
}
