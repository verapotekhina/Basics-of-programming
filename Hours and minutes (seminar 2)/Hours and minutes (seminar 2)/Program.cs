using System;

namespace Hours_and_minutes__seminar_2_
{
    class Program
    {
        static int Count(int hours, int min)
        {
            int angle1 = 0;  //обнуление счётчиков
            int angle2 = 0;

            if (hours > 12) //поскольку на циферблате часов в 2 раза меньше чем в сутках, стрелка бывает на каждом два раза, и в целом, нам без разницы для расчёта, первая это половина дня или вторая
                hours = hours - 12;
            for (int i = 0; i < hours; i++)  //считаем угол часовой стрелки
                angle1 += 30;
            for (int i = 0; i < min; i++)    //минутной, соответственно
                angle2 += 6;
            
            return Math.Abs(angle1-angle2);  //вычитаем из одного другой и берём модуль, чтобы угол не был отрицательным
        }
        static void Main()
        {
            Console.Write("Enter hours: ");   
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Enter minutes: ");
            int min = int.Parse(Console.ReadLine());

            Console.Write("Angle is: ");
            Console.WriteLine(Count(hours, min)); //вызов метода и вывод на экран
        }
    }
}
