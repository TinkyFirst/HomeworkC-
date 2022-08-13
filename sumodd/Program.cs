using System;
using System.Threading;

namespace sumodd
{
    class Program
    {
        static void Main(string[] args)
        {
            uint oddNumberCount = 0;
            uint evenNumberCount = 0;
            int sumOddNumber = 0;
            int sumEvenNumber = 0;

            Console.WriteLine("Введіть початкове число");
            int currentValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть кінцеве число");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    oddNumberCount++;
                    sumEvenNumber += currentValue;
                }
                else
                {
                    evenNumberCount++;
                    sumOddNumber += currentValue;
              
                }

                currentValue++;
            }

            Console.WriteLine("Кількісьб парних чисел - " +  evenNumberCount);
            Console.WriteLine("Кількісьб  непарних чисел - " +  oddNumberCount);
            Console.WriteLine("Cума  непарних чисел - " +  sumOddNumber);
            Console.WriteLine("Cума  парних чисел - " +  sumEvenNumber);
        }
    }
}