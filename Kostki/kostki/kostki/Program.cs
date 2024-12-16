using System.Xml.Serialization;

namespace kostki
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool choice = true;
            do
            {
                Console.WriteLine("podaj liczbe kostek (3-10)");
                bool czyCyfra = int.TryParse(Console.ReadLine(), out int liczba);
                while (czyCyfra == false || liczba < 3 || liczba > 10)
                {
                    Console.WriteLine("podaj liczbe kostek (3-10)");
                    czyCyfra = int.TryParse(Console.ReadLine(), out liczba);
                }
                short[] tab = new short[liczba];
                int suma = 0;

                int jeden = 1;
                int dwa = 1;
                int trzy = 1;
                int cztery = 1;
                int piec = 1;
                int szesc = 1;

                int[] wyrzuconeKostki = new int[liczba];

                for (int i = 0; i < tab.Length; i++)
                {
                    Random random = new Random();

                    tab[i] = (short)random.Next(1, 7);
                    Console.WriteLine($"kostka {i + 1}: {tab[i]}");
                    for (int j = 0; j < i; j++)
                    {
                        if (tab[j] == tab[i])
                        {
                            switch (tab[j])
                            {
                                case 1:
                                    jeden += 1; //informacja o tym ile razy dana wartosc stala wyrzucona na kostce
                                    break;

                                case 2:
                                    dwa += 1;
                                    break;

                                case 3:
                                    trzy += 1;
                                    break;

                                case 4:
                                    cztery += 1;
                                    break;

                                case 5:
                                    piec += 1;
                                    break;

                                case 6:
                                    szesc += 1;
                                    break;
                            }
                            break;
                        }
                    }
                }

                int punkty = 0;

                if (jeden > 1)
                {
                    punkty += jeden * 1;
                }
                if (dwa > 1)
                {
                    punkty += dwa * 2;
                }

                if (trzy > 1)
                {
                    punkty += trzy * 3;
                }
                if (cztery > 1)
                {
                    punkty += cztery * 4;
                }
                if (piec > 1)
                {
                    punkty += piec * 5;
                }
                if (szesc > 1)
                {
                    punkty += szesc * 6;
                }

                Console.WriteLine($"Liczba punktów: {punkty}");

                string userInput = "";
                do
                {                    
                    Console.Write("Jeszcze raz? (t/n): ");
                    userInput = Console.ReadLine();

                    if (userInput.ToUpper() == "T")
                    {
                        choice = true;
                    }
                    else if (userInput.ToUpper() == "N")
                    {
                        choice = false;
                    }

                }while (userInput.ToUpper() != "T" && userInput.ToUpper() != "N");
            }while(choice);
        }
    }
}
