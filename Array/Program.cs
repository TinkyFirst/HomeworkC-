using System;
using System.Linq;
using System.Threading.Channels;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.WriteLine("Введіть кількість обьектів в массиві");
         int arrayLenght = int.Parse(Console.ReadLine());
         int[] myArray = new int[arrayLenght];

         for (int i = 0; i < myArray.Length; i++)
         {
             Console.WriteLine($"Введіть {i} елемент");
             myArray[i] = int.Parse(Console.ReadLine());
             
         }

         for (int i = arrayLenght -1; i >= 0; i--)
         {
             Console.WriteLine(myArray[i]);
         }
        }
    }
}