using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter an integer:");
        int n;
        if (int.TryParse(Console.ReadLine(), out n) && n > 0)
        {
            Console.WriteLine("The sum of all prime numbers up to " + n + " is: " + SumOfPrimes(n));
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a positive integer.");
        }
    }

    public static int SumOfPrimes(int n)
    {
        int sum = 0;

        for (int i = 2; i <= n; i++)
        {
            if (IsPrime(i))
            {
                sum += i;
            }
        }

        return sum;
    }

    public static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        if (n == 2 || n == 3) return true;
        if (n % 2 == 0 || n % 3 == 0) return false;

        int i = 5;
        int w = 2;

        while (i * i <= n)
        {
            if (n % i == 0) return false;

            i += w;
            w = 6 - w;
        }

        return true;
    }
}