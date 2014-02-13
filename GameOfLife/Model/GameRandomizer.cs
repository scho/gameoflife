using System;

namespace GameOfLife.Model
{
    public class GameRandomizer
    {
        private bool[][] field;
        private readonly Random random;

        public GameRandomizer()
        {
            random = new Random();
        }

        public bool[][] Randomize(int width, int height)
        {
            InitializeField(height);
            SetField(width, height);
            return field;
        }

        private void InitializeField(int height)
        {
            field = new bool[height][];
        }

        private void SetField(int width, int height)
        {
            for (var i = 0; i < height; i++)
            {
                SetCell(width, i);
            }
        }

        private void SetCell(int width, int i)
        {
            field[i] = new bool[width];

            for (var j = 0; j < width; j++)
            {
                field[i][j] = GetRandomBool();
            }
        }

        private bool GetRandomBool()
        {
            return random.Next(0, 2) == 1;
        }
    }
}