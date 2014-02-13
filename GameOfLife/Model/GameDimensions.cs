namespace GameOfLife.Model
{
    public class GameDimensions
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public GameDimensions(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
