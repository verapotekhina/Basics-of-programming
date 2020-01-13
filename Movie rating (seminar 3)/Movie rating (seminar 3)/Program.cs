using System;
using System.Globalization;

namespace Movie_rating__seminar_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            double x = double.Parse(arr[0], CultureInfo.InvariantCulture);
            double y = double.Parse(arr[1], CultureInfo.InvariantCulture);
            int n = int.Parse(arr[2], CultureInfo.InvariantCulture);
            int i = 0;
            double a = x * n;

            if (( y < 1)||(y > 10))
                Console.WriteLine("Impossible");
            else
            {
                while (Math.Round(x, 1) > y)
                {
                    a++;
                    n++;
                    i++;
                    x = a / n;
                }
                Console.WriteLine(i);
            }
        }
    }
}
