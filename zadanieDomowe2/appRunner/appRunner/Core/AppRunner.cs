using appRunner.Console;
using appRunner.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appRunner.Core
{
    public class AppRunner
    {
        IDatabaseInstance _databaseInstance;
        IMyConsole _myConsole;

        public AppRunner(IDatabaseInstance databaseInstance, IMyConsole myConsole)
        {
            _databaseInstance = databaseInstance;
            _myConsole = myConsole;
        }
        public void StartApp()
        {
            _myConsole.WriteLine("Start aplikacji, wczytuje serwisy...");
        }

        public void ConnectToDb()
        {
            _databaseInstance.Connect();
        }

        public void Read()
        {
            _myConsole.WriteLine("Odczytuje dane z bazy");
        }


    }
}
