using ConsoleToDoList.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToDoList.Services
{
    public class Menu : IMenu
    {
        public void ShowMainMenu()
        {
            Console.Clear();
            Console.WriteLine("0. Filtruj");
            Console.WriteLine("1. Wyświetl liste");
            Console.WriteLine("2. Dodaj zadanie");
            Console.WriteLine("3. Edytuj");
            Console.WriteLine("4. Wyjdź");
        }
        public void ShowStatusMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Done");
            Console.WriteLine("2. InProgress");
            Console.WriteLine("3. Waiting");
        }
        public void ShowEditMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Edytuj status");
            Console.WriteLine("2. Edytuj zadanie");
            Console.WriteLine("3. Usuń");
            Console.WriteLine("4. Wróć");
        }
    }
}
