using System;

public class SortTestsTrial
{
    public static void Main(string[] args)
    {
        int[] numbers = new int[20];
        SortTests obj = new SortTests();

        obj.ReadFromFile(numbers);
        obj.DisplayArray(numbers);

        Console.ReadLine();
    }
}
