using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicesConsole
{
    public class DicesCollection : IEnumerable<DiceModel>
    {
        public List<DiceModel> _dices;
        public DicesCollection()
        {
            _dices = new List<DiceModel>();
        }
        /* ************************************************************
         * nazwa: AddDice
         * opis: dodaje obiekt typu DiceModel do listy
         * parametry: DiceModel
         * zwracany typ: brak
         * autor: ....
         * ************************************************************
         */
        public void AddDice(DiceModel dice)
        {
            _dices.Add(dice);
        }
        /* ************************************************************
         * nazwa: GetEnumerator
         * opis: zwraca enumerator
         * parametry: brak
         * zwracany typ: IEnumerator<DiceModel>
         * autor: ....
         * ************************************************************
         */
        public IEnumerator<DiceModel> GetEnumerator()
        {
            return new DiceEnumarator(this);
        }
        /* ************************************************************
         * nazwa: GetEnumerator
         * opis: 
         * parametry: 
         * zwracany typ: 
         * autor: ....
         * ************************************************************
         */
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        /* ************************************************************
         * nazwa: CalculatePoints
         * opis: zwraca liczbę punktów
         * parametry: brak
         * zwracany typ: int
         * autor: ....
         * ************************************************************
         */
        public int CalculatePoints()
        {
            var counts = new Dictionary<int, int>();

            foreach (var result in _dices)
            {
                if (counts.ContainsKey(result.GetResult()))
                {
                    counts[result.GetResult()]++;
                }
                else
                {
                    counts[result.GetResult()] = 1;
                }
            }

            int totalPoints = 0;
            foreach (var pair in counts)
            {
                if (pair.Value > 1)
                {
                    totalPoints += pair.Key * pair.Value;
                }
            }

            return totalPoints;
        }
    }

    public class DiceEnumarator : IEnumerator<DiceModel>
    {
        private readonly DicesCollection _diceCollection;
        private int _currentIndex;

        public DiceEnumarator(DicesCollection collection)
        {
            _diceCollection = collection;
            _currentIndex = -1;
        }

        public DiceModel Current => _diceCollection._dices[_currentIndex];
        object IEnumerator.Current => Current;
        public bool MoveNext()
        {
            _currentIndex++;
            return _currentIndex < _diceCollection._dices.Count;
        }
        public void Reset()
        {
            _currentIndex = -1;
        }
        public void Dispose() { }
    }
}
