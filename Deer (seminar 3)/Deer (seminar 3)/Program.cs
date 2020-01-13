using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deer__seminar_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split(' ');
            int l = int.Parse(arr[0]);
            int k = int.Parse(arr[1]);
            int h = int.Parse(arr[2]);
            double s2;

            double s1 = l / k * h;
            if (1 % k == 0)
                s2 = s1;
            else
            {
                double d = l / k;
                Math.Floor(d);
                 
            }

            
            Console.Write(s1 + " " + s2);
        }
    }
}
