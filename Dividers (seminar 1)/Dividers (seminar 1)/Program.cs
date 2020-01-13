using System;

/*
 * Потехина Вера - 1 семинар, 4 задача - Делители
 * Найти количество чисел меньших N, которые имеют простые делители X или Y.
 */

namespace Dividers__seminar_1_
{
    class Program
    {
        static int Func(int n, int x, int y)         //Метод, который считает количество чисел меньших N, которые имеются делители Х или Y
        {
            int a = 0;                               //Обнуляем счётчик
            for (int i = 0; i < n; i++)              //Для каждого числа от 0 до N 
            {
                if ((i % x == 0) || (i % y == 0))    //происходит проверка на соответствие нужному условию
                    a++;                             //если число подходит, к счётчику добавляется единица
            }
            return a;                                //возвращает количество чисел, которые соответствовали условию
        }
        static void Main()
        {
            Console.WriteLine("Enter N: ");          //считывание n, x, y;
            int n = int.Parse(Console.ReadLine());   
            Console.WriteLine("Enter X (divider): ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y(divider): ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Result: ");           
            Console.WriteLine(Func(n, x, y));       //вызывается метод для расчёта, метод возвращает результат, он сразу же выводится
        }
    }
}
