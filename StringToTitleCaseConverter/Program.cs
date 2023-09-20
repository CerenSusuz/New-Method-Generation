using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();
        Console.WriteLine("Original string: " + input);
        string titleCase = ToTitleCase(input);
        Console.WriteLine("Title case string: " + titleCase);
    }

    public static string ToTitleCase(string input)
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

        return textInfo.ToTitleCase(input);
    }
}