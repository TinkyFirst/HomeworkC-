using System;

namespace cube
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите высоту куба");
            int height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ширину куба");
            int width = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write('#');
                }
                
                Console.WriteLine();
            }
        }
    }
}