using System;

//Cond2. Пролезет ли брус со сторонами x, y, z в отверстие со сторонами a, b, если его разрешается поворачивать на 90 градусов?

namespace Block__seminar_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter x, y, z, a, b: ");
            string[] arr = Console.ReadLine().Split(' ');
            double x = double.Parse(arr[0]);
            double y = double.Parse(arr[1]);
            double z = double.Parse(arr[2]);
            double a = double.Parse(arr[3]);
            double b = double.Parse(arr[4]);

            Console.Write("Result: ");
            if ((a >= x) && (b >= y) || (a >= y) && (b >= x)) //сравниваем каждую сторону бруска с размерами отверстия
                Console.WriteLine("Yes");
            else if ((a >= y) && (b >= z) || (a >= z) && (b >= y))
                Console.WriteLine("Yes");
            else if ((a >= x) && (b >= z) || (a >= z) && (b >= x))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }
    }
}
