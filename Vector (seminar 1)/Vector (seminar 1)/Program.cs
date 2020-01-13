using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Потехина Вера - 1 семинар, 7 задача - Вектор
 * 
 * Найти вектор, параллельный прямой. Перпендикулярный прямой.
 * 
 * Поскольку форма ввода не оговорена, предположим, вводятся коэффициенты А, В, С уравнения прямой Ах + Ву + С = 0 (упрощаю себе жизнь, ага)
 * Тогда перпендикулярный вектор - вектор нормали - будет иметь координаты (А, В), а параллельный вектор - направляющий вектор - координаты (-В, А)
 * 
 * Что-то слишком просто для задачи под номером 7
 */

namespace Vector__seminar_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The equation of the line: A*x + B*y + C = 0.");
            Console.Write("Enter A: ");                //просьбы ввести коэффициенты из уравнения и считывание
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter B: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter C: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("The normal vector: ("); //вывод координат вектора нормали
            Console.Write(a);
            Console.Write(", ");
            Console.Write(b);
            Console.WriteLine(")");

            Console.Write("Parallel vector: ("); //вывод координат направляющего вектора
            Console.Write(-b);
            Console.Write(", ");
            Console.Write(a);
            Console.WriteLine(")");
        }
    }
}
