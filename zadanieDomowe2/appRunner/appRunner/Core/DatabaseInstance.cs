using appRunner.Console;
using appRunner.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appRunner.Core
{
    public class DatabaseInstance : IDatabaseInstance
    {
        readonly string _connectionString;
        IMyConsole _myConsole;

        public DatabaseInstance(string connectionString, IMyConsole myConsole)
        {
            _connectionString = connectionString;
            _myConsole = myConsole;
        }

        public void Connect()
        {
            string connectionString = _connectionString; //tutaj byłaby cała logika do łączenia się z bazą danych
            _myConsole.WriteLine("Łącze z bazą danych...");
        }
    }
}
