using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("How many units of fizzing and buzzing do you need in your life?");
            string input = Console.ReadLine();
            Int32.TryParse(input, out int num);
            
            for (int i = 1; i < num; i++)
            {
                if (!(i % 5 == 0 || i % 3 == 0))
                {
                    Console.WriteLine(i);
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }

                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
            }
            Console.WriteLine("TRADITION!!!!!");

        }
    }
}
