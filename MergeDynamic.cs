using System;

class MergeSortFive
{
    static void Main()
    {
        Console.WriteLine("*** Merge Sort (5 Numbers Only) ***\n");

        Console.WriteLine("Enter 5 numbers:");
        string[] input = Console.ReadLine().Split(' ');

        int[] arr = new int[5];

        for (int i = 0; i < 5; i++)
        {
            arr[i] = int.Parse(input[i]);
        }

        Console.WriteLine("\nOriginal Array:");
        Console.WriteLine(string.Join(", ", arr));

        MergeSort(arr, 0, arr.Length - 1);

        Console.WriteLine("\nSorted Array:");
        Console.WriteLine(string.Join(", ", arr));
    }

    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;

            MergeSort(arr, left, middle);
            MergeSort(arr, middle + 1, right);

            Merge(arr, left, middle, right);
        }
    }

    static void Merge(int[] arr, int left, int middle, int right)
    {
        int n1 = middle - left + 1;
        int n2 = right - middle;

        int[] L = new int[n1];
        int[] R = new int[n2];

        Array.Copy(arr, left, L, 0, n1);
        Array.Copy(arr, middle + 1, R, 0, n2);

        int i = 0, j = 0, k = left;

        while (i < n1 && j < n2)
        {
            if (L[i] <= R[j])
            {
                arr[k++] = L[i++];
            }
            else
            {
                arr[k++] = R[j++];
            }
        }

        while (i < n1)
        {
            arr[k++] = L[i++];
        }

        while (j < n2)
        {
            arr[k++] = R[j++];
        }
    }
}
