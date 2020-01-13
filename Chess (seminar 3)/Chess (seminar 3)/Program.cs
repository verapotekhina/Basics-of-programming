using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Cond1. Дана начальная и конечная клетки на шахматной доске. Корректный ли это ход на пустой доске для: слона, коня, ладьи, ферзя, короля?
/*слон - по диагонали
 *ладья - по прямой
 *конь - Г (две вперёд, одна - в бок)
 *ферзь - слон + ладья
 *король - на одну клетку во все стороны
 * 
 * у 'a' индекс 97
 */

namespace Chess__seminar_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first cell: ");
            string a = Console.ReadLine();
            Console.WriteLine("Enter the second cell: ");
            string b = Console.ReadLine();
            Console.WriteLine("Еnter chess piece (elephant, horse, rook, queen, king): ");
            string c = Console.ReadLine();
            bool result;
            int fail = 0;

            if (c == "elephant")
            {
                result = Elephant(a, b);
            }
            else if (c == "rook")
            {
                result = Rook(a, b);
            }
            else if (c == "queen")
            {
                result = Queen(a, b);
            }
            else if (c == "horse")
            {
                result = Horse(a, b);
            }
            else if (c == "king")
            {
                result = King(a, b);
            }
            else
            {
                fail = 1;
                result = false;
            }

            if (fail != 1)
            {
                if (result == true)
                    Console.WriteLine("correct");
                else
                    Console.WriteLine("incorrect");
            }
            else
                Console.WriteLine("input error");
        }

        static bool Elephant(string a, string b)
        {
            return Math.Abs(a[0] - b[0]) == Math.Abs(a[1] - b[1]);
        }

        static bool Rook(string a, string b)
        {
            return (a[0] == b[0]) && (a[1] != b[1])|| (a[0] != b[0]) && (a[1] == b[1]);
        }

        static bool Queen(string a, string b)
        {
            return Rook(a, b)|| Elephant(a, b);
        }

        static bool Horse(string a, string b)
        {
            return (Math.Abs(a[0] - b[0]) == 2) && (Math.Abs(a[1] - b[1]) == 1)|| (Math.Abs(a[0] - b[0]) == 1) && (Math.Abs(a[1] - b[1]) == 2);
        }

        static bool King(string a, string b)
        {
            return (Math.Abs(a[0] - b[0]) ==  1) && (Math.Abs(a[1] - b[1]) == 1)|| (Math.Abs(a[0] - b[0]) == 0) && (Math.Abs(a[1] - b[1]) == 1)|| (Math.Abs(a[0] - b[0]) == 1) && (Math.Abs(a[1] - b[1]) == 0);
        }

    }
}
