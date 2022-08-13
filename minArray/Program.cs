using System;

namespace minArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { -5, 2, 3, 4, 5, 6, };
            int minValue = myArray[0];

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] < minValue)
                {
                    minValue = myArray[i];
                }
                
            }

            Console.WriteLine(minValue);
        }
    }
}