using System;
using System.Collections.Generic;
using System.Linq;

namespace vladtask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Enter the number of numbers in the array \t");
            int arrayCount = int.Parse(Console.ReadLine());

            int[] myArray = new int[arrayCount];

            Console.Write("Enter the start of the array\t");
            int arrayStart = int.Parse(Console.ReadLine());

            Console.Write("Write the end of the array\t");
            int arrayEnd = int.Parse(Console.ReadLine());

            Random random = new Random();   //  Створення масивву рандому
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = random.Next(arrayStart, arrayEnd);
            }
            
            int sumOfArray = 0;
            int countMoreZero = 0;
            int[] countMoreZeroArray = new int[sumOfArray];
            int countLessZero = 0; //Ініаціалізація параметрів

            Console.WriteLine("Array output");
            Console.WriteLine();
            foreach (var numbers in myArray)
            {
                Console.Write(numbers + " ");
            }


            foreach (var numbers in myArray) //The number of elements is greater than zero
            {
                if (numbers > 0)
                {
                    countMoreZero++;
                }
            }

            foreach (var numbers in myArray) //The number of elements is less than zero
            {
                if (numbers < 0)
                {
                    countLessZero++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("The maximum value of the array \t " + myArray.Max());
            Console.WriteLine();
            Console.WriteLine("The minimum value of the array \t " + myArray.Min());
            Console.WriteLine();
            Console.WriteLine("Plus than zero array values \t " + countMoreZero);
            Console.WriteLine();
            Console.WriteLine("The sum of the array \t " + myArray.Sum());
            Console.WriteLine();
            Console.WriteLine($"The number of elements is greater than zero: {countMoreZero}");
            Console.WriteLine();
            Console.WriteLine($"The number of elements is less than zero: {countLessZero}");
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}