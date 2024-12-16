namespace Eratostenes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] array = new bool[99]; // deklaracja tablicy typu bool z 99 elemntami (od 2 do 100)

            InitializeArray(array); // wywołanie funkcji i przekazanie tablicy array do funkcji

            for (int i = 2; i < Math.Sqrt(array.Length); i++) // pętla od i = 2 do i = 9
            {
                if (array[i] == true) // jeśli wartość pod indeksem i jest prawdziwa to przejdź do ciała ifa
                {
                    int result = 0; // deklaracja zmiennej dla wyniku mnożenia
                    for (int j = 2; result < 100; j++) // pętla od j = 2 dopóki result (wynik mnożenia < 100). W każdym kroku j++
                    {
                        /* mnożenie - wielkrotności liczby
                         * jeśli i = 2 to pętla działa następująco: 2 * 2, 2 * 3, 2 * 4...
                         * jeśli i = 3 to pętla działa następująco: 3 * 2, 3 * 3, 3 * 4...
                         */
                        result = i * j; // przypisanie wyniku mnożenia
                        if (result < 99) // jeśli wynik mnożenia jest mniejszy niż 99 (czyli max 98 - tyle ile mamy indeksów w tablicy)
                        {                            
                            array[j * i] = false; // zmień wartość na false
                        }
                    }
                }
            }
            bool wasWritten = false; // warunek do wypisania pierwszej liczby bez przecinka
            for (int i = 2; i < array.Length; i++) // dla wszystkich indeksów w tablicy wypisz
            {               
                if (array[i] == true && wasWritten == false) // jeśli wartość pod indeksem i jest prawdziwa oraz zmienna wasWritten jest true
                {
                    Console.Write($"{i}");
                    wasWritten = true;
                }
                else if(array[i] == true && wasWritten == true)
                {
                    Console.Write($", {i}");
                }
            }


        }

        static void InitializeArray(bool[] array) // definicja funkcji która ma wypełnić naszą tablicę
        {
            for (int i = 0; i < array.Length; i++) // pętla od i = 0 do i = 98
            {
                array[i] = true; // przypisz true
            }
        }
    }
}
