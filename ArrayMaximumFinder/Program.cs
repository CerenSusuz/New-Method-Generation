using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the number of elements in the array: ");
        int n;
        if (int.TryParse(Console.ReadLine(), out n) && n > 0)
        {
            int[] arr = new int[n];
            Console.WriteLine("Enter the elements of the array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Element " + (i + 1) + ": ");
                while (!int.TryParse(Console.ReadLine(), out arr[i]))
                {
                    Console.Write("Invalid input. Enter element " + (i + 1) + " again: ");
                }
            }

            int max = FindMax(arr);
            Console.WriteLine("The maximum element in the array is: " + max);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }

    public static int FindMax(int[] arr)
    {
        int max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }

        return max;
    }
}