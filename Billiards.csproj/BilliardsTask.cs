using System;

namespace Billiards
{
	public static class BilliardsTask
	{
		public static double BounceWall(double directionRadians, double wallInclinationRadians)
		{
            if (wallInclinationRadians == 90)
                return (Math.PI - (Math.PI - (wallInclinationRadians - directionRadians) * 2) / 2);
            else if (wallInclinationRadians == 0)
                return (Math.PI*2 - directionRadians);
            else
                return ((wallInclinationRadians - directionRadians) * 2 + directionRadians);
        }
	}
}