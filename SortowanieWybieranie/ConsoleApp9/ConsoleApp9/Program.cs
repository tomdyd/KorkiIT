using ConsoleApp9;
Console.WriteLine("podaj 10 cyfr");
int[] tablica = [1, 2, 3, 4, 5, 6, 100, 99, 7, 25];
//for(int i = 0;  i < 10; i++)
//{
//    Console.Write($"podaj {i+1} cyfre: ");
//    bool czyCyfra = int.TryParse(Console.ReadLine(), out int cyfra);
//    while (czyCyfra == false)
//    {
//        Console.Write($"podaj {i + 1} cyfre: ");
//         czyCyfra = int.TryParse(Console.ReadLine(), out  cyfra);
//    }
//    tablica[i] = cyfra;
//}
int number = 0;
Sortowanie tak = new Sortowanie(tablica);
tak.Sortuj();

 