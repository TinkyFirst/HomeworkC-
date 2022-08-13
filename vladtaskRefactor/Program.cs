using System;
using System.Collections.Generic;
using System.Linq;

namespace vladtaskRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            var list = new List<int>();
            InitializedList(list, 20);
            
            var list2 = new List<int>();


            PrintList(list);
            Console.WriteLine();
            Console.WriteLine("Max value in list \t" + list.Max());
            
            Console.WriteLine("Min value in list \t" + list.Min());
            
            Console.WriteLine("Sum value in list \t"  + list.Sum());
            
            var listMoreZero = new List<int>();
            var listLessZero = new List<int>();

           
            if (IsBiggerList(listMoreZero,listLessZero))
            {
                Console.WriteLine("than more big than zero");
            }
            else
            {
                Console.WriteLine("than more less than zero");
            }

        }

        private static void PrintList(List<int> list)
        {
            foreach (var el in list)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
            
        }

        private static void InitializedList(List<int> createList, int count)
        {
            var random = new Random();
            for (var i = 0; i < count; i++)
            {
                
                createList.Add(random.Next(-50, 50));
            }
        }
        
        private static bool IsBiggerList(List<int> firstList, List<int> secondList)
        {
            return firstList.Count > secondList.Count;
        }
        
    }
}