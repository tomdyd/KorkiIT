namespace peselChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj numer PESEL: ");
            string? pesel = Console.ReadLine();

            peselModel peselModel = new peselModel();

            while (!peselModel.CheckPesel(pesel ?? string.Empty))
            {
                Console.Write("Podano błędny numer PESEL. Spróbuj ponownie: ");
                pesel = Console.ReadLine();
                pesel ??= string.Empty ;
                peselModel.CheckPesel(pesel);
                Console.Clear();
            }

            char sex = peselModel.CheckSex();
            bool isGood = peselModel.VerifyCheckSum(pesel ?? string.Empty);

            if (sex == 'K')
            {
                Console.WriteLine("Kobieta");
            }
            else
            {
                Console.WriteLine("Mężczyzna");
            }

            if (isGood)
            {
                Console.WriteLine("Numer PESEL jest poprawny");
            }
            else
            {
                Console.WriteLine("Numer PESEL jest niepoprawny");
            }
        }
    }
}
