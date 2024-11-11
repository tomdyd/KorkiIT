﻿class Program
{
    static void Main()
    {
        int[] array = { 34, 7, 23, 32, 5, 62 };

        Console.WriteLine("Array before sorting:");
        PrintArray(array);

        QuickSort(array, 0, array.Length - 1);

        Console.WriteLine("\nArray after sorting:");
        PrintArray(array);
    }

    static void QuickSort(int[] array, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(array, left, right);
            QuickSort(array, left, pivotIndex - 1);
            QuickSort(array, pivotIndex + 1, right);
        }
    }

    static int Partition(int[] array, int left, int right)
    {
        int pivot = array[right];  // wybieramy ostatni element jako pivot
        int i = left - 1;          // indeks mniejszego elementu

        for (int j = left; j < right; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                Swap(array, i, j);
            }
        }

        Swap(array, i + 1, right);
        return i + 1;
    }

    static void Swap(int[] array, int a, int b)
    {
        int temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }

    static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}
