using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Sortowanie
    {
        int[] _tablica = new int[10];
        int tempInt = 0;

        public Sortowanie(int[] tablica)
        {
            _tablica = tablica;
        }

        private int Szukaj(int j)
        {
            int max = 0;
            for (int i = j; i < _tablica.Length-1; i++) {
                
                if (i == j)
                {
                    max = i;
                    tempInt = _tablica[max];
                }
                if(_tablica[max] < _tablica[i+1])
                {
                    max = i + 1;
                    tempInt = _tablica[max];
                }
            }
            return max;
        }
        public void Sortuj()
        {
            for(int i = 0; i < _tablica.Length - 1 ; i++)
            {
                int index = Szukaj(i);
                
                int temp = _tablica[i];
                _tablica[i] = _tablica[index];
                _tablica[index] = temp;                
            }
            
            for(int i = 0; i < _tablica.Length ;i++)
            {
                Console.WriteLine(_tablica[i]);
            }
        }
    }

}
