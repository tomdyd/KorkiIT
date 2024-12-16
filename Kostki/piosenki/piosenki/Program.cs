using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "C:\\Users\\tdyda\\source\\repos\\KorkiIT\\2024\\Data.txt";
        try
        {
            foreach (string line in File.ReadLines(filePath))
            {
                Console.WriteLine(line);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Wystąpił błąd: {ex.Message}");
        }
    }
}
