using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { 
          Console.WriteLine("Введите количество гривны для перевода");
         double valueUah = double.Parse(Console.ReadLine());
         Console.WriteLine("Введите курс долара");
         double valueDollar = double.Parse(Console.ReadLine());
         double changeMoney = valueUah / valueDollar;
         Console.WriteLine("Это будет = " + changeMoney);
 



        }
    }
    
}