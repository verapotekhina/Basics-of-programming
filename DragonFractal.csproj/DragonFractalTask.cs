// В этом пространстве имен содержатся средства для работы с изображениями. Чтобы оно стало доступно, в проект был подключен Reference на сборку System.Drawing.dll
using System.Drawing;
using System;

namespace Fractals
{
	internal static class DragonFractalTask
	{
        static void NewCoordinate(ref double x, ref double y, int nextNumber)
        { 
            if (nextNumber == 0)
            {
                var x1 = (x * Math.Cos(Math.PI / 4) - y * Math.Sin(Math.PI / 4)) / Math.Sqrt(2);
                var y1 = (x * Math.Sin(Math.PI / 4) + y * Math.Cos(Math.PI / 4)) / Math.Sqrt(2);
                x = x1;
                y = y1;
            }
            else
            {
                var x1 = (x*Math.Cos(Math.PI-Math.PI/4)-y*Math.Sin(Math.PI-Math.PI/4))/Math.Sqrt(2)+1;
                var y1 = (x*Math.Sin(Math.PI-Math.PI/4)+y*Math.Cos(Math.PI-Math.PI/4))/Math.Sqrt(2);
                x = x1;
                y = y1;
            }
        }

        public static void DrawDragonFractal(Pixels pixels, int iterationsCount, int seed)
        {
            double x = 1;
            double y = 0;
            pixels.SetPixel(x, y);
            var random = new Random(seed);  // seed — число полностью определяющее все последовательность псевдослучайных чисел этого генератора.

            for (int i = 0; i < iterationsCount; i++)
            {
                var nextNumber = random.Next(seed) % 2;
                NewCoordinate(ref x, ref y, nextNumber);
                pixels.SetPixel(x, y);
            }
        }
    }
}