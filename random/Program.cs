using System;
using System.Collections.Generic;

namespace random
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
        
            var random = new Random();
            Console.WriteLine("Enter count number in list");
            int countList = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter start number in list");
            int startRandom = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter end number in list");
            int endRandom = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < countList; i++)
            {
                list.Add(random.Next(startRandom, endRandom));
            }

           PrintConsole(list);
            
            
        }
        private static void  PrintConsole(List<int> list)
        {
            foreach (var number in  list)
            {
                Console.WriteLine(number + "");
            }
        }
    }
}