using System.Reflection.Metadata.Ecma335;

namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int i = 0;
            bool[] table = new bool[99];


            fillTable(table);

            for (i = 2; i < Math.Sqrt(n); i++)
            {
                if (table[i] == false)
                {
                    continue;
                }

                int result = 0;
                for (int j = 2; result < 100; j++)
                {                    
                    result = i * j;
                    if (result < 99)
                    {
                        table[result] = false;
                    }
                }
            }

            for (int k = 2; k < table.Length; k++)
            {
                if (table[k] == true)
                {
                    Console.Write($"{k}, ");
                }
            }
        }

        static void fillTable(bool[] table)
        {
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = true;
            }
        }
    }
}
