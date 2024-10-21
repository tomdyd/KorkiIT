using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class PeselModel
    {
        private string Pesel { get; set; }
        public int S { get; set; }
        public int M { get; set; }
        public int R { get; set; }
        public void SetPesel(string pesel)
        {
            if (pesel.Length == 11)
            {
                Pesel = pesel;
            }
            else
            {
                while (pesel.Length != 11)
                {
                    Console.WriteLine("bledny pesel, podaj jeszcze raz");
                    pesel = Console.ReadLine();
                    if (pesel.Length == 11)
                    {
                        Pesel = pesel;
                    }
                }
            }
        }
        public char checkGender()
        {
            if (Pesel[9] % 2 == 0)
            {
                return 'K';
            }
            return 'm';
        }

        public string GetPesel()
        {
            return Pesel;
        }

        public void Waga()
        {
            int[] wagi = new int[] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            S = 0;
            for (int i = 0; i < 10; i++)
            {
                S += Pesel[i] * wagi[i];
                //var temp = Pesel[i];
                //var temp1 = temp.ToString();
                //var temp2 = int.Parse(temp1);

                S += int.Parse(Pesel[i].ToString()) * wagi[i];
            }

            M = S % 10;
            R = 10 - M;

            if (R == int.Parse(Pesel[10].ToString()))
            {
                Console.WriteLine("PESEL jest poprawny.");
            }
            else
            {
                Console.WriteLine("PESEL jest niepoprawny.");
            }
        }

    }

}