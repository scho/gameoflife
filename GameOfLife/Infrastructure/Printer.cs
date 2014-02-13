using GameOfLife.Model;

namespace GameOfLife.Infrastructure
{
    class Printer
    {
        private readonly Game game;
        private readonly IWriter writer;

        public Printer(Game game, IWriter writer)
        {
            this.game = game;
            this.writer = writer;
        }

        public void Print()
        {
            ClearScreen();
            PrintHeadline();
            PrintGame();
        }

        private void ClearScreen()
        {
            writer.Clear();
        }

        private void PrintHeadline()
        {
            writer.WriteLine(" --- This is Conway's Game of Life ---");
            writer.WriteLine();
        }

        private void PrintGame()
        {
            foreach (var row in game.ToStringCollection())
            {
                writer.WriteLine(" " + row);
            }
        }
    }
}
