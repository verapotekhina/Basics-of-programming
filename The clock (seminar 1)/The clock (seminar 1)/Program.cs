﻿using System;

/*
 * Потехина Вера - 1 семинар, 3 задача - Стрелки часов
 * 
 * Задано время Н часов (ровно). Вычислить угол в градусах между часовой и минутной стрелками. Например, 5 часов -> 150 градусов, 20 часов -> 120 градусов. Не использовать циклы.
 */

namespace The_clock__seminar_1_
{
    class Program
    {
        static int Error(int n)         //метод проверки введенного значения на корректность
        {
            if ((n > 23) || (n < 0))    //из здравого смысла - 24 часом считают 0, ну нам-то не привыкать (:
                n = -1;
            return n;
        }
        static int Func(int n)           //метод для определения угла, чтобы не перегружать Main (странный метод, но они сами хотели без циклов)
        {
            if ((n == 0) || (n == 12))   //поскольку каждой цифре на циферблате соответсвует по два часа за сутки, в каждом условии пара чисел, которым соответсвует один и тот же угол, 
                n = 0;                   //он и присваивается той же переменнной (ибо незачем ещё одна,в данной задаче выполнение одного условия исключает выполнение всех остальных)
            if ((n == 23) || (n == 11))
                n = 330;
            if ((n == 22) || (n == 10))
                n = 300;
            if ((n == 21) || (n == 9))
                n = 270;
            if ((n == 20) || (n == 8))
                n = 240;
            if ((n == 19) || (n == 7))
                n = 210;
            if ((n == 18) || (n == 6))
                n = 180;
            if ((n == 17) || (n == 5))
                n = 150;
            if ((n == 16) || (n == 4))
                n = 120;
            if ((n == 15) || (n == 3))
                n = 90;
            if ((n == 14) || (n == 2))
                n = 60;
            if ((n == 13) || (n == 1))
                n = 30;
            return n;
        }
        static void Main(string[] args)    
        {
            Console.WriteLine("Enter the clock (for example, 15): "); //просьба ввести время
            int n = int.Parse(Console.ReadLine());  //считывание введенной строки, перевод в int

            if (Error(n) == -1)                     //если ввод был не корректным - сообщение об ошибке
                Console.WriteLine("Error! Сhange the time");
            else                          
            {
                Console.Write("Аngle is ");       
                Console.WriteLine(Func(n));       //запуск метода, определяющего угол и вывод результата
            }
        }
    }
}
