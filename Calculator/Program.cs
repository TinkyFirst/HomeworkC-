using System;


namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double firstNumber, secondNumber;
                try
                {
                    Console.WriteLine("Введіть перше число");
                    firstNumber = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введіть друге число");
                    secondNumber = double.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Введено недійсне число");
                    Console.ReadLine();
                    continue;
                }


                Console.WriteLine("Введіть знак операнда");
                string action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstNumber + secondNumber);
                        break;
                    case "-":
                        Console.WriteLine(firstNumber - secondNumber);
                        break;
                    case "*":
                        Console.WriteLine(firstNumber * secondNumber);
                        break;
                    case "/":
                        Console.WriteLine(firstNumber / secondNumber);
                        break;
                    default:
                        Console.WriteLine("Некоректно введено знак операнда");
                        break;
                }

                Console.ReadLine();

            }
        }
    }
}