using System;

/*  Потехина Вера - 1 семинар, 8 задача
 * 
 *  Дана прямая L и точка A. Найти точку пересечения прямой L с перпендикулярной ей прямой P, проходящей через точку A.
 *  
 *  Хм, решение этой задачи - просто кусок кода из 6 задачи, ну да ладно, повторение - мать учения
 *  
 *  Поскольку вид входных данных не оговорён, предположим, что вводятся коэффициенты k и b из уравнения прямой y = k*x + b и координаты точки a
 */
namespace Intersection__seminar_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The equation of the line: y = k * x + b."); //просьбы ввести данные и считывание
            Console.Write("Enter k: ");
            double k1 = double.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the x coordinate: ");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the y coordinate: ");
            double y1 = double.Parse(Console.ReadLine());

            double k2 = -1 / k1;                 //вычисляется коэффициент наклона второй прямой (из свойства перпендикулярных прямых)
            double b2 = y1 - k2 * x1;            //вычисляется свободный член в уравнении этой прямой

            double x2 = (b1 - b2) / (k2 - k1);   //вычисляется координата х точки пересечения двух перпендикулярных прямых
            double y2 = k1 * x2 + b1;            //и координата у

            Console.Write("Intersection: (");    //вывод ответа 
            Console.Write(x2);
            Console.Write(", ");
            Console.Write(y2);
            Console.WriteLine(")");
        }
    }
}
