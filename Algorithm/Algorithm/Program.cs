using System.Reflection.Metadata.Ecma335;

namespace Algorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            int i = 0;
            int[] table = new int[99];


            fillTable(table);

            for (i = 0; i < Math.Sqrt(n); i++)
            {
                if (table[i] == 0)
                {
                    i++;
                    continue;
                }

                int result = 0;
                int[] table1 = new int[99];

                for (int j = 2; result < 101; j++)
                {
                    result = table[i] * j;
                    table1[j] = result;
                }

                for (int k = 0; k < 99; k++)
                {
                    for (int l = 0; l < 99; l++)
                    {
                        if (table[k] == table1[l])
                        {
                            table[k] = 0;
                        }
                    }
                }
            }

            foreach (var oddNumber in table)
            {
                if (oddNumber != 0)
                {
                    Console.Write($"{oddNumber}, ");
                }
            }
        }

        static void fillTable(int[] table)
        {
            for (int i = 0; i < table.Length; i++)
            {
                table[i] = i + 2;
            }
        }
    }
}
