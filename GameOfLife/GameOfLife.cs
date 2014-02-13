using GameOfLife.Infrastructure;
using GameOfLife.Model;

namespace GameOfLife
{
    class GameOfLife
    {
        static void Main(string[] args)
        {
            new GameOfLife().Run();
        }

        private readonly Game game;

        private readonly Printer printer;

        public GameOfLife()
        {
            var initialState = new GameRandomizer().Randomize(new GameDimensions(78, 21));
            
            game = new Game(initialState);
            printer = new Printer(game, new ConsoleWriter());
        }

        public void Run()
        {
            while (true)
            {
                Print();
                Tick();
                Sleep();
            }
        }

        private void Tick()
        {
            game.Tick();
        }

        private void Print()
        {
            printer.Print();
        }

        private void Sleep()
        {
            System.Threading.Thread.Sleep(150);
        }
    }
}