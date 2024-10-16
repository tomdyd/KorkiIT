using appRunner.Console;
using appRunner.Core;
using appRunner.Interfaces;

namespace appRunner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMyConsole myConsole = new MyConsole();
            IDatabaseInstance databaseInstance = new DatabaseInstance("192.168.0.1", myConsole);

            AppRunner appRunner = new AppRunner(databaseInstance, myConsole);
            
            appRunner.StartApp();

            appRunner.ConnectToDb();

            appRunner.Read();
        }
    }
}
