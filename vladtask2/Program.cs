using System;
using System.Collections.Generic;
using System.Linq;

namespace vladtask2
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomList = InitializedList(10).OrderBy(x => x).ToList();

            PrintList(randomList);
            var currency = CurrencyTransfer(300, 40);
            Console.WriteLine(currency);
            var month = Month(5);
            Console.WriteLine(month);
            var minusArray = MinusList(randomList);
            var plusArray = PlusList(randomList);
            PrintList(minusArray);
            PrintList(plusArray);
            var unionArray = UnionList(randomList, randomList);
            PrintList(unionArray);
        }

        private static List<int> InitializedList(int count)
        {
            var createList = new List<int>();
            var random = new Random();
            for (var i = 0; i < count; i++)
            {
                createList.Add(random.Next(-50, 50)); // 1) Inilialized List
            }

            return createList;
        }

        private static void PrintList(List<int> printArray)
        {
            foreach (var numbers in printArray)
            {
                Console.Write(numbers + " ");
            }

            Console.WriteLine(); // 2) Print list
        }

        private static List<int> MinusList(List<int> list)
        {
            var minusArray = new List<int>();

            foreach (var number in list)
            {
                if (number < 0)
                {
                    minusArray.Add(number);
                }
            }

            return minusArray; // 3) Create minus array
        }

        private static List<int> PlusList(List<int> list)
        {
            var plusArray = new List<int>();

            foreach (var number in list)
            {
                if (number > 0)
                {
                    plusArray.Add(number);
                }
            }

            return plusArray; // 4) Create plus array
        }

        private static List<int> FilteredList(List<int> firstList, List<int> secondList)
        {
            foreach (var number in firstList)
            {
                var filterList = firstList.Except<int>(secondList);
            }

            return firstList; // 5) Filter List 
        }

        private static List<int> UnionList(List<int> firstList, List<int> secondList)
        {
            var unitedList = new List<int>();
            firstList.AddRange(secondList);
            return firstList;
        } // 6) United two list

        private static string Month(int numberMonth)
        {
            switch (numberMonth)
            {
                case 1:
                    return "January";
                case 2:
                    return "February";
                case 3:
                    return "March";
                case 4:
                    return "April";
                case 5:
                    return "May";
                case 6:
                    return "June";
                case 7:
                    return "July";
                case 8:
                    return "August";
                case 9:
                    return "September";
                case 10:
                    return "October";
                case 11:
                    return "November";
                case 12:
                    return "December";
                default:
                    return "error";
            }
            // 7) MountDecode
        }

        private static int CurrencyTransfer(int uah, int currencyDollar)
        {
            int resultCurrency = uah / currencyDollar;

            return resultCurrency; // 8) Transfer Currency
        }
    }
}