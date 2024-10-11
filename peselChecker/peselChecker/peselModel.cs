using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace peselChecker
{
    public class peselModel
    {
        private string PeselNumber { get; set; }
        public int S { get; set; }
        public int M { get; set; }
        public int R { get; set; }

        private void SetPeselNumber(string pesel)
        {
            PeselNumber = pesel;
        }

        public bool CheckPesel(string pesel)
        {
            if (pesel.Length == 11)
            {
                SetPeselNumber(pesel);
                return true;
            }
            return false;
        }

        public char CheckSex()
        {
            if (PeselNumber[9] % 2 == 0)
            {
                return 'K';
            }
            else
            {
                return 'M';
            }
        }

        public bool VerifyCheckSum(string pesel)
        {
            int[] weights = new int[] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int[] productOfNumbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                {
                    int digit = (int)char.GetNumericValue(pesel[i]);
                    productOfNumbers[i] = digit * weights[i];
                }
            }

            foreach (int number in productOfNumbers)
            {
                S += number;
            }

            M = S % 10;

            if (M == 0)
            {
                R = 0;
            }
            else
            {
                R = 10 - M;
            }

            if (R == (int)char.GetNumericValue(pesel[pesel.Length - 1]))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
