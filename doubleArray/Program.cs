using System;

namespace doubleArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 5];
            myArray[1, 1] = 5;
            Console.WriteLine(myArray[1,1]);

        }
    }
}