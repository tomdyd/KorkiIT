namespace appRunner.Interfaces
{
    public interface IMyConsole
    {
        void WriteLine(string message);
        void Write(string message);
        string ReadLine();
        void Clear();
    }
}