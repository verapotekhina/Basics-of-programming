using System;

/* 
 * Потехина Вера - 1 семинар, 1 задача - Обмен
 * 
 * Как поменять местами значения двух переменных? Можно ли это сделать без ещё одной временной переменной. Стоит ли так делать?
 */

namespace Swap__seminar_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: "); //просьбы ввести два числа и считывание введённых значений
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int b = int.Parse(Console.ReadLine());

            int c = b; //с помощью дополнительной переменной осуществлям обмен значений
            b = a;
            a = c;

            Console.WriteLine("the first number: "); //вывод
            Console.WriteLine(a);
            Console.WriteLine("the second number: ");
            Console.WriteLine(b);
        }
    }
}
