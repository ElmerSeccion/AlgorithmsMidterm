using System;

class BubbleSortFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("=== Bubble Sort (5 Numbers Input) ===\n");
        Console.WriteLine("Enter 5 numbers:");
        
        // Read input and split into 5 numbers
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = new int[5];

        for (int i = 0; i < 5; i++)
        {
            arr[i] = int.Parse(input[i]);
        }

        Console.WriteLine("\nOriginal Array:");
        Console.WriteLine(string.Join(", ", arr));

        BubbleSort(arr);

        Console.WriteLine("\nSorted Array:");
        Console.WriteLine(string.Join(", ", arr));
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

            if (!swapped)
                break;
        }
    }
}
