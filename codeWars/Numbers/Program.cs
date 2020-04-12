using System;

namespace Numbers {
    class Program {
        static void Main (string[] args) 
        {
            CreatePhoneNumber (new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 });
        }

        public static string CreatePhoneNumber (int[] numbers) 
        {
            var num = string.Join ("", numbers);
            var first = num.Substring (0, 3);
            var second = num.Substring (3, 3);
            var third = num.Substring (6, 4);
            var tele = $"({first}) {second}-{third}";
            return tele;
        }

        public static string CreatePhoneNumber1 (int[] nums) {
            return $"({nums[0]}{nums[1]}{nums[2]}) {nums[3]}{nums[4]}{nums[5]}-{nums[6]}{nums[7]}{nums[8]}{nums[9]}";
        }

        public static string CreatePhoneNumber2 (int[] numbers) 
        {
            var phone = "(";
            for (int i = 0; i < numbers.Length; i++) {
                phone += numbers[i].ToString ();

                if (i == 2)
                    phone += ") ";

                if (i == 5)
                    phone += "-";
            }
            return phone;
        }
    }
}