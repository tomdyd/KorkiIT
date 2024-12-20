using ConsoleToDoList.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToDoList.Services
{
    public class MenuHandler(IMenu menu, IFileHandler fileHandler) : IMenuHandler
    {
        private readonly IMenu _menu = menu;
        private readonly IFileHandler _fileHandler = fileHandler;

        public int Handle()
        {
            bool isChoiceValid;
            int choice;
            do
            {
                Console.Write("Wybierz opcje: ");
                isChoiceValid = int.TryParse(Console.ReadLine(), out choice);

            } while (!isChoiceValid);

            return choice;

        }
        public string GetData()
        {
            Console.Write("Zmień treść zadania: ");
            var userInput = Console.ReadLine();
            if (userInput != null)
            {
                return userInput;
            }
            else
            {
                throw new Exception();
            }
        }
        public void HandleMainMenu()
        {
            _menu.ShowMainMenu();
            int status;
            switch (Handle())
            {
                case 0:
                    _menu.ShowStatusMenu();
                    status = Handle();
                    _fileHandler.PrintTasks((TaskStatus)status);
                    Console.WriteLine("Kliknij dowolny przycisk aby kontynuować");
                    Console.ReadKey();
                    break;
                case 1:
                    _fileHandler.PrintTasks();
                    Console.WriteLine("Kliknij dowolny przycisk aby kontynuować");
                    Console.ReadKey();

                    break;
                case 2:
                    Console.WriteLine("Wprowadź zadanie: ");
                    var task = Console.ReadLine();
                    if (task != null)
                    {
                        _fileHandler.AddTask(task);
                    }

                    break;
                case 3:
                    HandleEditMenu();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
        public void HandleEditMenu()
        {
            int id;
            int status;
            _menu.ShowEditMenu();

            switch (Handle())
            {
                case 1:
                    _fileHandler.PrintTasks();
                    id = Handle(); // Console.ReadLine()

                    _menu.ShowStatusMenu();

                    status = Handle();

                    _fileHandler.ChangeStatus(id, (TaskStatus)status);
                    _fileHandler.PrintTasks();

                    Console.WriteLine("Wciśnij dowolny przycisk aby kontynuować");
                    Console.ReadKey();
                    break;
                case 2:
                    _fileHandler.PrintTasks();
                    id = Handle();
                    _fileHandler.ChangeTask(id, GetData());
                    break;
                case 3:
                    _fileHandler.PrintTasks();
                    id = Handle();
                    _fileHandler.DeleteTask(id);
                    break;
                case 4:
                    break;
            }
        }
    }
}
