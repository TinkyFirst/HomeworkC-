using System;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            
            switch (number) 
            {
                case 1:
                    Console.WriteLine("Ваше число 1 ");
                    break;
                case 2:
                    Console.WriteLine("Ваше число 2 ");
                    break;
                case 3:
                    Console.WriteLine("Ваше число 3");
                    break;
                default:
                    Console.WriteLine("Ваше число больше 3 ");
                    break;
            }
        }
    }
}