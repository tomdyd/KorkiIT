namespace DicesConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char answer = ' ';
            do
            {
                DicesCollection diceCollection = new DicesCollection();
                Console.WriteLine("Ile kostek chcesz rzucić>(3 - 10)");
                bool isNumber = int.TryParse(Console.ReadLine(), out int userInput);

                while (!isNumber || userInput < 3 || userInput > 10)
                {
                    Console.WriteLine("Ile kostek chcesz rzucić>(3 - 10)");
                    isNumber = int.TryParse(Console.ReadLine(), out userInput);
                }

                for (int i = 0; i < userInput; i++)
                {
                    DiceModel dice = new DiceModel();
                    dice.RollTheDice();
                    diceCollection.AddDice(dice);
                }

                int index = 1;

                foreach (var dice in diceCollection)
                {
                    Console.WriteLine($"Kostka {index}: {dice.GetResult()}");
                    index++;
                }

                int points = diceCollection.CalculatePoints();

                Console.WriteLine($"Liczba punktów: {points}");
                Console.WriteLine("Jeszcze raz? (t/n)");
                answer = Console.ReadLine().ToLower()[0];

                while (answer != 't' && answer != 'n')
                {
                    Console.WriteLine("Jeszcze raz? (t/n)");
                    answer = Console.ReadLine().ToLower()[0];
                }

            } while(answer == 't');
        }
    }
}
