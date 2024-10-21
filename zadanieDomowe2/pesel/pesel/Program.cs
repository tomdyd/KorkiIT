using ConsoleApp;

PeselModel peselModel = new PeselModel();

Console.WriteLine("podaj pesel");
peselModel.SetPesel(Console.ReadLine());

char gender = peselModel.checkGender();
Console.WriteLine(gender);
Console.WriteLine("**");
Console.WriteLine(peselModel.checkGender());
peselModel.Waga();
//checkGender1(peselModel.GetPesel());

// static  void checkGender1(string pesel)
//{
//    if (pesel[9] % 2 == 0)
//    {
//        Console.WriteLine("jestes kobieta");
//    }
//       else
//    {
//        Console.WriteLine("jestes chlopem");
//    }
//}