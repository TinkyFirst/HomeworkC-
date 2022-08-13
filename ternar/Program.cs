using System;
using System.Threading.Channels;

namespace ternar
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputData = int.Parse(Console.ReadLine());

            int result = (inputData  < 0) ? 0 : inputData;
            Console.WriteLine(result);

        }
    }
}