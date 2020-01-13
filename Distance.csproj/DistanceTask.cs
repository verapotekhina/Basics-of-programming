using System;

namespace DistanceTask
{
	public static class DistanceTask
	{
		// Расстояние от точки C(x, y) до отрезка AB с координатами A(ax, ay), B(bx, by)
		public static double GetDistanceToSegment(double ax, double ay, double bx, double by, double x, double y)
		{
            
            //координаты вектора АВ
            double vecABx = bx - ax;
            double vecABy = by - ay;
            //координаты вектора BA
            double vecBAx = ax - bx;
            double vecBAy = ay - by;
            //координаты вектора AC
            double vecACx = x - ax;
            double vecACy = y - ay;
            //координаты вектора BC
            double vecBCx = x - bx;
            double vecBCy = y - by;
            //скалярное произведение - сумма произведений соответсвенных координат и произведение длин векторов на косинус между ними - нам даст возвожность через косинус 
            //проверить, где находится точка
            double scalarABAС = vecABx * vecACx + vecABy * vecACy;
            double scalarBABС = vecBAx * vecBCx + vecBAy * vecBCy;
            //найдём длину
            double lengthAB = Math.Sqrt(vecBAx * vecBAx + vecBAy * vecBAy);
            if (lengthAB == 0)
                return Math.Sqrt(vecACx * vecACx + vecACy * vecACy);

            else if ((scalarABAС < 0)||(scalarBABС < 0))
            {
                double AC = Math.Sqrt(vecACx * vecACx + vecACy * vecACy);
                double BC = Math.Sqrt(vecBCx * vecBCx + vecBCy * vecBCy);
                return Math.Min(BC, AC);
            }
            else
            {
                double dividend = vecABx * vecACy - vecABy * vecACx;
                double divisor = Math.Sqrt(vecABx * vecABx + vecABy * vecABy);
                return Math.Abs(dividend / divisor);
            }
        }
	}
}