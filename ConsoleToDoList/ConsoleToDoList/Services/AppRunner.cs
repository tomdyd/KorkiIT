using ConsoleToDoList.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleToDoList.Services
{
    public class AppRunner(IMenuHandler menuHandler)
    {
        private readonly IMenuHandler _menuHandler = menuHandler;

        public void Start()
        {            
            while (true)
            {
                _menuHandler.HandleMainMenu();                
            }
        }
       
    }
}
                    

