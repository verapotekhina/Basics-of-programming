using System;

/* Потехина Вера - 1 семинар, 5 задача - Високосные года
 * 
 * Найти количество високосных лет на отрезке [a, b] не используя циклы.
 */

namespace Leap_year__seminar_1_
{
    class Program
    {
        static int Func(int a, int b)                                 //метод, подсчитывающий количество високосных лет 
        {
            int n = 0;                                                //обнуление счётчика лет    
            
            for (int i = a; i < (b + 1); i++)                         //для всех чисел от a до b включительно 
            { 
                if ((i % 4 == 0)&&((i % 100 != 0) || (i % 400 == 0))) //проверяется условие высокосного года - номер года делится без остатка на 4, 
                    n++;                                              //но при этом не делится без остатка на 100 или делится на 400
            }

            return n;                                                 //возвращает количество високосных лет за выбранный период             
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the first year: ");                  //просьбы ввести временной отрезок и считывание данных
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter second year: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Leap year: ");
            Console.WriteLine(Func(a, b));                            //вызов метода, подсчитывающего количество високосных лет и вывод на экран результата
        }
    }
}
