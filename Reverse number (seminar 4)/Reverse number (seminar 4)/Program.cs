﻿using System;

namespace Reverse_number__seminar_4_
{
    class Program
    {
        public enum Mark
        {
            Empty,
            Cross,
            Circle
        }

        public enum GameResult
        {
            CrossWin,
            CircleWin,
            Draw
        }

        public static void Main()
        {
            Run("XXX OO. ...");
            Run("OXO XO. .XO");
            Run("OXO XOX OX.");
            Run("XOX OXO OXO");
            Run("... ... ...");
            Run("XXX OOO ...");
            Run("XOO XOO XX.");
            Run(".O. XO. XOX");
        }

        private static void Run(string description)
        {
            Console.WriteLine(description.Replace(" ", Environment.NewLine));
            Console.WriteLine(GetGameResult(CreateFromString(description)));
            Console.WriteLine();
        }

        private static Mark[,] CreateFromString(string str)
        {
            var field = str.Split(' ');
            var ans = new Mark[3, 3];
            for (int x = 0; x < field.Length; x++)
                for (var y = 0; y < field.Length; y++)
                    ans[x, y] = field[x][y] == 'X' ? Mark.Cross : (field[x][y] == 'O' ? Mark.Circle : Mark.Empty);
            return ans;
        }

        public static GameResult GetGameResult(Mark[,] field)
        {
            var res = 0;
            var type = Mark.Empty;

            Horizontal(field, ref res, ref type);
            Vertical(field, ref res, ref type);
            Diagonal(field, ref res, ref type);
            if (res == 1)
            {
                if (type == Mark.Cross)
                    return GameResult.CrossWin;
                else
                    return GameResult.CircleWin;
            }
            else
                return GameResult.Draw;
        }

        private static void Vertical(Mark[,] field, ref int res, ref Mark type)
        {
            for (int j = 0; j < 3; j++)
            {
                if ((field[0, j] == field[1, j]) && (field[0, j] == field[2, j]) && (field[0, j] != Mark.Empty))
                {
                    type = field[0, j];
                    res++;
                }
            }
        }

        private static void Horizontal(Mark[,] field, ref int res, ref Mark type)
        {
            for (int i = 0; i < 3; i++)
            {
                if ((field[i, 0] == field[i, 1]) && (field[i, 0] == field[i, 2]) && (field[i, 0] != Mark.Empty))
                {
                    type = field[i, 0];
                    res++;
                }
            }
        }

        private static void Diagonal(Mark[,] field, ref int res, ref Mark type)
        {
            if ((field[0, 0] == field[1, 1]) && (field[0, 0] == field[2, 2]) && (field[0, 0] != Mark.Empty))
            {
                type = field[0, 0];
                res++;
            }

            if ((field[0, 2] == field[1, 1]) && (field[2, 0] == field[0, 2]) && (field[0, 0] != Mark.Empty))
            {
                type = field[0, 2];
                res++;
            }
        }





    }
}
