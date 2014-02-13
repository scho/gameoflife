using System;

namespace GameOfLife.Model
{
    public class GameRandomizer
    {
        private bool[][] gameState;
        private readonly Random random;

        public GameRandomizer()
        {
            random = new Random();
        }

        public bool[][] Randomize(int width, int height)
        {
            InitializeGameState(height);
            SetGameRows(width, height);
            return gameState;
        }

        private void InitializeGameState(int height)
        {
            gameState = new bool[height][];
        }

        private void SetGameRows(int width, int height)
        {
            for (var row = 0; row < height; row++)
            {
                SetGameStateRow(width, row);
            }
        }

        private void SetGameStateRow(int width, int row)
        {
            gameState[row] = new bool[width];

            for (var column = 0; column < width; column++)
            {
                gameState[row][column] = GetRandomCellState();
            }
        }

        private bool GetRandomCellState()
        {
            return random.Next(0, 2) == 1;
        }
    }
}