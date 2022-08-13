using System;

namespace forCicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сколько раз написать сообщения");
            int summaryMesseage = int.Parse(Console.ReadLine());
            for (int i = 0, j = 5; i <= summaryMesseage; i++, j--)
            {
                Console.WriteLine(i);
                Console.WriteLine(j);
                
            }
        }
    }
}