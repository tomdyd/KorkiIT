using System.ComponentModel;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("PODAJ LICZBE 1:");
            //string number = Console.ReadLine();
            //int numberInt = int.Parse(number);
            //Console.WriteLine(number.GetType());
            //Console.WriteLine(numberInt.GetType());

            //Console.WriteLine("---------------");
            //Console.WriteLine("PODAJ LICZBE 2: ");
            //int number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine(number2.GetType());

            //Console.WriteLine("-------------");
            //Console.WriteLine("PODAJ LICZBE 3: ");

            //bool isNumber = int.TryParse(Console.ReadLine(), out int number3);
            //Console.WriteLine($"{number3.GetType()} {number3}");

            //while (isNumber == false)
            //{
            //    Console.WriteLine("Podaj liczbe jeszcze raz: ");
            //    isNumber = int.TryParse(Console.ReadLine(), out number3);
            //}

            //int number4;
            //Console.WriteLine(number4.GetType());

            //int userInput = int.Parse(Console.ReadLine());

            //if (userInput < 3)
            //{
            //    Console.WriteLine("BŁĄD");
            //}
            //else if (userInput > 10)
            //{
            //    Console.WriteLine("BŁĄD");
            //}
            //else
            //{
            //    Console.WriteLine("POPRAWNIE");
            //}

            ////jezeli userInput jest mniejszy od 3 i jest wiekszy od 10

            //if (userInput < 3 || userInput > 10)
            //{
            //    Console.WriteLine("BŁĄD");
            //}
            //else
            //{
            //    Console.WriteLine("POPRAWNIE");
            //}

            //Class1 class1 = new Class1();
            //int a = 5;
            //int b = 10;

            //class1.Calculate(a, b);

            //Console.WriteLine("-------------------");

            //int result = class1.Calculate1(a, b);
            //Console.WriteLine($"wynik {result}");

            //Class1 class1 = new Class1();

            //int number = int.Parse(Console.ReadLine());
            //class1.SetNumber(number);
            //Console.WriteLine(class1.getNumber());

            //Console.WriteLine("podaj rodzaj domu? ");
            //string rodzaj = Console.ReadLine();

            //Console.WriteLine("podaj adres: ");
            //string adres = Console.ReadLine();

            //Console.WriteLine("podaj lokatorów: ");
            //int ilosc = int.Parse(Console.ReadLine());

            //Dom dom = new Dom();
            //dom.Typ = rodzaj;
            //dom.Adres = adres;
            //dom.SetLokatorzy(ilosc);

            //Console.WriteLine($"typ: {dom.Typ} adres: {dom.Adres} lokatorzy: {dom.GetLokatorzy}");

            /********************************************************************************
             To tylko do podglądu, ponższy kod nie działa, bo nie ma klasy DomKolekcja
             *******************************************************************************/
            //DomKolekcja domKolekcja = new DomKolekcja();

            //for (int i = 0; i < 6; i++)
            //{
            //    Dom dom = new Dom();

            //    dom.Typ = ($"dom{i}");
            //    dom.Adres = ($"adres{i}");
            //    dom.SetLokatorzy(i);

            //    DomKolekcja.add(dom);
            //}

            //for (int i = 0; i < domKolekcja.Count, i++)
            //{
            //    Console.WriteLine($"{domKolekcja[i].Typ}, {domKolekcja[i].Adres}, {domKolekcja[i].GetLokatorzy} ");
            //}

        }
    }
}
