using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using appRunner.Interfaces;

namespace appRunner.Console
{
    public class MyConsole : IMyConsole
    {
        public void Clear()
        {
            System.Console.Clear();
        }
        public string ReadLine()
        {
            return System.Console.ReadLine();
        }

        public void Write(string message)
        {
            System.Console.Write(message + " //output w konsoli z mojej klasy");
        }

        public void WriteLine(string message)
        {
            System.Console.WriteLine(message + " //output w konsoli z mojej klasy");
        }
    }
}
