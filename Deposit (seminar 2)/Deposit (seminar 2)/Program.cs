using System;

/*Создайте новый проект с типом Console Application.
Напишите программу, которая, используя метод Console.ReadLine(), вводит строку, содержащую три числа через пробел — сумму, процентную ставку (в процентах) и срок вклада, а потом на основе этих значений вычисляет накопившуюся сумму на момент окончания вклада. Результат нужно вывести на консоль.
Не забудьте выделить код, решающий задачу в отдельную от ввода и вывода функцию.
Детали:

В конце каждого месяца происходит капитализация — к сумме прибавляется накопившийся за месяц процент. Далее процент вычисляется от этой увеличенной суммы.
Процентная ставка — годовая (то есть в конце месяца сумма на счете увеличивается на одну двенадцатую ставки)
Считайте, что вклад открыт в первый день месяца, а срок вклада — это целое количество месяцев.
Код, решающий основную задачу нужно оформить в виде метода Calculate, принимающего строку, введенную пользователем. В этой задаче гарантируется, что ввод корректный.
*/

namespace ConsoleApp1
{
    class Program
    {
        static double Count(double sum, double per, int time)
        {
            for (int i = 0; i < time; i++)
            {
                double w = sum / 100 / 12 * per; //прибавляется в месяц w рублей
                sum = sum + w;
            };

            return sum;
        }
        public static double Calculate(string userInput)               //этот метод существует только потому, что на улёрне странная проверялка, мяу :с
        {
            int index = userInput.IndexOf(' ');                        //упоротое считывание строки и разделение её на отдельные переменные (потому что я не знала, что есть split)
            double sum = double.Parse(userInput.Substring(0, index));
            userInput = userInput.Remove(0, index + 1);

            index = userInput.IndexOf(' ');
            double per = double.Parse(userInput.Substring(0, index));
            userInput = userInput.Remove(0, index + 1);

            index = userInput.Length;
            int time = int.Parse(userInput.Substring(0, index));
            userInput = userInput.Remove(0, index);

            return Count(sum, per, time);  
        }

        static void Main()
        {
            Console.WriteLine("Enter the amount of deposit, percent and term:");
            Console.WriteLine(Calculate(Console.ReadLine()));

        }
    }
}
