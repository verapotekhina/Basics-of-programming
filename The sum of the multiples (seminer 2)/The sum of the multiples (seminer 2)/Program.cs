using System;

namespace The_sum_of_the_multiples__seminer_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0; //обнуление счётчика
            for (int i = 0; i < 1000; i++) //для всех положительных целых чисел до 1000
            {
                if ((i % 3 == 0) || (i % 5 == 0)) //если условие верно
                    sum = sum + i;                //к счётчику прибавляется единица
            }
            Console.WriteLine("Result: " + sum);               //вывод результата
        }
    }
}
