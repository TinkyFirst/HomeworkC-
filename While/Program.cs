using System;
using System.Threading;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int limit = int.Parse(Console.ReadLine());
            while (count <= limit) 
            {
                count++;
                Console.WriteLine(count);
                
            }
        }
    }
}