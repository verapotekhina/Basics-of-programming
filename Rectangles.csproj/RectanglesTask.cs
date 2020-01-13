using System;

namespace Rectangles
{
	public static class RectanglesTask
	{
		// Пересекаются ли два прямоугольника (пересечение только по границе также считается пересечением)
		public static bool AreIntersected(Rectangle r1, Rectangle r2)
		{
            if ((r2.Left - r1.Left - r1.Width > 0) || (r2.Top - r1.Top - r1.Height > 0))
                return false;
            else if ((r1.Left - r2.Left - r2.Width > 0) || (r1.Top - r2.Top - r2.Height > 0))
                return false;
            else
                return true;            
            // так можно обратиться к координатам левого верхнего угла первого прямоугольника: r1.Left, r1.Top
		}

		// Площадь пересечения прямоугольников
		public static int IntersectionSquare(Rectangle r1, Rectangle r2)
		{
            if (AreIntersected(r1, r2) == false)
                return 0;
            else if ((r2.Left - r1.Left - r1.Width == 0) || (r2.Top - r1.Top - r1.Height == 0))
                return 0;
            else if ((r1.Left - r2.Left - r2.Width == 0) || (r1.Top - r2.Top - r2.Height == 0))
                return 0;
            else
            {
                int a = Math.Max(r1.Top, r2.Top);
                int b = Math.Min(r1.Height + r1.Top, r2.Top + r2.Height);
                int c = Math.Abs(a - b);
                a = Math.Max(r1.Left, r2.Left);
                b = Math.Min(r1.Width + r1.Left, r2.Width + r2.Left);
                int d = Math.Abs(a - b);
            
                return c * d; 
            }
        }

		// Если один из прямоугольников целиком находится внутри другого — вернуть номер (с нуля) внутреннего.
		// Иначе вернуть -1
		// Если прямоугольники совпадают, можно вернуть номер любого из них.
		public static int IndexOfInnerRectangle(Rectangle r1, Rectangle r2)
		{
            if ((r2.Left >= r1.Left) && (r2.Left + r2.Width <= r1.Left + r1.Width) && (r2.Top >= r1.Top) && (r2.Top + r2.Height <= r1.Top + r1.Height))
                return 1;
            else if ((r1.Left >= r2.Left) && (r1.Left + r1.Width <= r2.Left + r2.Width) && (r1.Top >= r2.Top) && (r1.Top + r1.Height <= r2.Top + r2.Height))
                return 0;
            else
                return -1;
		}
	}
}