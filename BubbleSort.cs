using System;

class BubbleSortDemo
{
    static void Main()
    {
        int[] bestCase = { 1, 2, 3, 4, 5 };
        int[] averageCase = { 3, 1, 4, 5, 2 };
        int[] worstCase = { 5, 4, 3, 2, 1 };

        Console.WriteLine("Bubble Sort Demonstration\n");

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
        BubbleSort(array);
        Console.WriteLine("Sorted:   " + string.Join(", ", array));
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            // Optimization: stop if no swaps occurred
            if (!swapped)
                break;
        }
    }
}