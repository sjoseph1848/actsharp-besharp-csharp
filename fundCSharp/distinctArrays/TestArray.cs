using System;

namespace distinctArrays 
{
    class TestArray 
    { 
        private int[] numbers = {1,7,2,4,2,3,8,4,6,4,4,7,12};

        public TestArray()
        {
            NumberOfElements = numbers.Length;
        }
        public int NumberOfElements {get;set;}

        public int ValidEntries()
        {
            int counter = 0;
            for (int i = 0; i < NumberOfElements; i++)
            {
                if(numbers[i] >= 0 && numbers[i] <= 10)
                    counter++;
            }
            return counter;
        }
    }
}