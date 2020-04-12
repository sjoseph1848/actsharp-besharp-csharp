using System;

namespace twoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int [] {-4,-1,1,3,5,6,8,11};
            var tests = TwoNumberSum(arr, 99);

            foreach(int test in tests){
                System.Console.WriteLine(test);
            }

        }

        private static int[] TwoNumberSum(int[] array, int targetSum)
        {
            Array.Sort(array);
            int left = 0;
            int right = array.Length - 1;
            while (left < right) {
                System.Console.WriteLine($"Right: {array[right]}");
                System.Console.WriteLine($"Left: {array[left]}");
                int currentSum = array[left] + array[right];
                if (currentSum == targetSum) {
                    return new int[] {array[left] , array[right]};
                } else if (currentSum < targetSum){
                    left++;
                } else if (currentSum > targetSum) {
                    right--;
                }
            }
            return new int[0];
        }

    }
}
