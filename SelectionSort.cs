using System;

class SelectionSortDemo
{
    static void Main()
    {
        int[] bestCase = { 1, 2, 3, 4, 5 };
        int[] averageCase = { 3, 1, 4, 5, 2 };
        int[] worstCase = { 5, 4, 3, 2, 1 };

        Console.WriteLine("Selection Sort Demonstration\n");

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
        SelectionSort(array);
        Console.WriteLine("Sorted:   " + string.Join(", ", array));
    }

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap the found minimum element with the first element
            int temp = arr[minIndex];
                arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }
}