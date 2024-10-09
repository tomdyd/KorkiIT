using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicesConsole
{
    public class DiceModel
    {
        private int Result { get; set; }

        /* ************************************************************
         * nazwa: GetResult
         * opis: zwraca wartość właściwości Result
         * parametry: brak
         * zwracany typ: int
         * autor: ....
         * ************************************************************
         */
        public int GetResult()
        {
            return Result;
        }
        /* ************************************************************
         * nazwa: RollTheDice
         * opis: przypisuje wartość losową do właściwości Result
         * parametry: brak
         * zwracany typ: int
         * autor: ....
         * ************************************************************
         */
        public void RollTheDice()
        {
            Random random = new Random();
            Result = random.Next(1, 7);
        }
    }
}
