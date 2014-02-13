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

        public bool[][] Randomize(GameDimensions dimensions)
        {
            InitializeGameState(dimensions);
            SetGameRows(dimensions);
            return gameState;
        }

        private void InitializeGameState(GameDimensions dimensions)
        {
            gameState = new bool[dimensions.Height][];
        }

        private void SetGameRows(GameDimensions dimensions)
        {
            for (var row = 0; row < dimensions.Height; row++)
            {
                SetGameStateRow(dimensions, row);
            }
        }

        private void SetGameStateRow(GameDimensions dimensions, int row)
        {
            gameState[row] = new bool[dimensions.Width];

            for (var column = 0; column < dimensions.Width; column++)
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