using System;
// Single Number
// Given a non-empty array of integers, every element appears twice except for one. Find that single one.
namespace LeetOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] {2,2,1};
            Array.Sort(nums);
            System.Console.WriteLine(nums);
            
            int a = nums[0];
            for(int i = 1; i < nums.Length; i++)
            {   
                a = a ^ nums[i];
            }
            System.Console.WriteLine(a);
        }
    }
}
