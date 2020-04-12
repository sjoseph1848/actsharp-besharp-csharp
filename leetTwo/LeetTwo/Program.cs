using System;
using System.Collections.Generic;

namespace LeetTwo
{
    class Program
    {
        static void Main(string[] args)
        {
           var numbers =  Happy(19);
           System.Console.WriteLine(numbers);
        }

        public static bool Happy(int n)
        {
            var visited = new Dictionary<int, bool>();

            var next = n;
            
            while (!visited.ContainsKey(next))
            {
                visited.Add(next, true);
                System.Console.WriteLine(next);
                var start = next;
                System.Console.WriteLine(start);
                next = 0;

                while (start != 0)
                {
                    next += (start % 10) * (start % 10);
                    start /= 10;
                }
                
                if (next == 1) return true;
            }

            return false;
        }
    }
}
