using System;

namespace Double.TryParse_s_Trap
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = double.NaN;
            Console.WriteLine(double.TryParse("1,2,,,,,,3", out result));

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
