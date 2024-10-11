using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Class1
    {
        private int Number { get; set; }

        public void SetNumber(int number)
        {
            Number = number;
        }

        public int getNumber()
        {
            return Number;
        }
    }
}
