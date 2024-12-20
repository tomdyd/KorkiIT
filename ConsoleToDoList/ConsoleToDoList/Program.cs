using ConsoleToDoList.Interfaces;
using ConsoleToDoList.Services;
using System.Xml.Serialization;

namespace ConsoleToDoList
{
    internal class Program
    {
        static void Main()
        {
            IMenu menu = new Menu();
            IFileHandler fileHandler = new FileHandler();
            IMenuHandler menuHandler = new MenuHandler(menu, fileHandler);
            var appRunner = new AppRunner(menuHandler);

            appRunner.Start();
        }
    }
}
