using System;
using System.Linq;
using System.Collections.Generic;

namespace Gas_Mileage
{
    class Program
    {
        static void Main()
        {
            List<int> miles = new List<int>();
            List<int> gallons = new List<int>();
            List<int> final_mpg = new List<int>();

            while (true)
            {
                Console.WriteLine("Input Miles driven, then gas used, 'q' to quit.");
                Console.Write("Input Miles driven: ");
                var _miles = Console.ReadLine();
                if (Convert.ToString(_miles) == "q"){break;}else{miles.Add(Convert.ToInt16(_miles));}

                Console.Write("Input Gallons used: ");
                var _gallons = Console.ReadLine();
                if (Convert.ToString(_gallons) == "q"){break;}else{gallons.Add(Convert.ToInt16(_gallons));}

                Console.WriteLine("");
            }

            int MPG = miles.Zip(gallons, (m, g) => new {miles = m, gallons = g });

            foreach (var datapoint in MPG)
            {
                final_mpg.Add(datapoint.Miles / datapoint.Gallons);
            }

            Console.WriteLine("Final MPG: {0}", (Convert.ToInt16((final_mpg.Average() * 100))) / 100);

            Console.WriteLine("Done!");
        }
    }
}
