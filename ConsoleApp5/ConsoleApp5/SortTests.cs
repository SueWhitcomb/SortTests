using System;
using System.IO;

public class SortTests
{


    public SortTests()
    {
    }
    public void ReadFromFile(int[] numbers)
    {
        string path = "c:\\users\\sue\\source\\repos\\ConsoleApp5\\ConsoleApp5\\numbers.txt";
        StreamReader sr = new StreamReader(path);

        for (int index = 0; index < numbers.Length; index++)
        {
            numbers[index] = Convert.ToInt32(sr.ReadLine());

        }
        sr.Close();
    }
    public void DisplayArray(int[] numbers)
    {
        for (int index = 0; index < numbers.Length; index++)
        {
            Console.WriteLine("{0}", numbers[index]);
        }
    }
}