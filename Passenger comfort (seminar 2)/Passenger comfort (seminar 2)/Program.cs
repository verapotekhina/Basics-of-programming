using System;

//на тимусе - №1885

namespace StyleErrors
{
    class Program
    {
        static double Min(double h, double t, double v, double x)
        {
            double f = (h - x * t) / (v - x); //формула движения h = v * f + x * (t - f), где f - минимальное время - выражаем из нее f
            return f;
        }

        static void Main()
        {
            Console.Write("Enter h, t, v, x in one line: ");
            string[] arr = Console.ReadLine().Split(' '); 
            double h = double.Parse(arr[0]); //присваивание значений переменным, чтобы формулы были понятнее
            double t = double.Parse(arr[1]);
            double v = double.Parse(arr[2]);
            double x = double.Parse(arr[3]);


            Console.Write(Min(h, t, v, x)); //вызов метода, для расчёта минимального времени и вывод результата
            Console.Write(' ');
            Console.WriteLine(t); //максимальное время всегда будет равно t
        }
    }
}
