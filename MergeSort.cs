using System;

class MergeSortDemo
{
    static void Main()
    {
        int[] bestCase = { 1, 2, 3, 4, 5 };
        int[] averageCase = { 3, 1, 4, 5, 2 };
        int[] worstCase = { 5, 4, 3, 2, 1 };

        Console.WriteLine("Merge Sort Demonstration\n");

        Console.WriteLine("Best Case (Already Sorted):");
        ShowSort(bestCase);

        Console.WriteLine("\nAverage Case (Random Order):");
        ShowSort(averageCase);

        Console.WriteLine("\nWorst Case (Reverse Sorted):");
        ShowSort(worstCase);
    }

    static void ShowSort(int[] array)
    {
        Console.WriteLine("Original: " + string.Join(", ", array));
        MergeSort(array, 0, array.Length - 1);
        Console.WriteLine("Sorted:   " + string.Join(", ", array));
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