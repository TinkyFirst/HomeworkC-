using System;

namespace Break
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
               

                if (i == 2)
                {
                    continue;
                }
                Console.WriteLine(i);

                if (i == 3)
                {
                    break;
                }
            }
        }
    }
}