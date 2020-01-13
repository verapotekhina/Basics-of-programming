//пустой лабиринт  - из верхнего левого угла дойти в нижний правый

namespace Mazes
{
	public static class EmptyMazeTask
	{
		public static void MoveOut(Robot robot, int width, int height)
		{
            int moveCount = 0; //количество шагов (вбок) - обнулили счётчик
            while (moveCount < (width - 3)) //сначала шагаем вправо до тех пор, пока количество шагов не станет равным `ширина минус три` - тройка - это клетки,
            {                               //на которые робот не сдвигается, то есть две клетки - правая и левая стенки, еще одна - та, на которой стоит изначально
                robot.MoveTo(Direction.Right);
                moveCount++;
            }
            moveCount = 0; //количество шагов (вниз) - обнулили счётчик
            while (moveCount < height - 3) //аналогично, шагает вниз
            {
                robot.MoveTo(Direction.Down);
                moveCount++;
            }

        }
	}
}