using System;

namespace Test
{
    class Program
    {
        static void Main()
        {
            int x = 1;
            int total = 0;

            while (x <= 10)
            {
                int y = x * x;
                Console.WriteLine(y);
                total += y;
                ++x;
            }

            Console.WriteLine($"Total is {total}");
        }
    }
}
