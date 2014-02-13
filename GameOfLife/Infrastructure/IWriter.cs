namespace GameOfLife.Infrastructure
{
    public interface IWriter
    {
        void Clear();
        void WriteLine(string format, params object[] args);
        void WriteLine();
    }
}
