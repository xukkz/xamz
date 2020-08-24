using System;

namespace test
{
    class Program
    {
        static void drawThousand()
        {
            for (int i = 1; i < 1001; i++)
            {
                if (i > 1 && (i % 3 == 0 && i % 5 == 0))
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Fizzbuzz!");
                }
                else if (i > 1 && i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Fizz!");
                }
                else if (i > 1 && (i % 5 == 0))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Buzz!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(i);
                }

            }
        }

        static void Main()
        {
            drawThousand();
            Console.ReadLine();
        }
    }
}

