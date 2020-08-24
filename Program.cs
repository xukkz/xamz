using System;

namespace test
{
    class Program
    {
        static void drawThousand()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(i + 1);
            }
        }
        static void modoThree()

        {
            bool modu = false;
            int x;
            x = 9;
            if ((x % 3) == 0)
            {
                modu = true;
            }
            Console.WriteLine(modu);
        }
        static void Main()
        {
            drawThousand();
            modoThree();
            Console.ReadLine();
        }
    }
}

