using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int num = -1;
        while (num != 0)
        {
            Console.Write("Enter number: ");
            string response = Console.ReadLine();
            num = int.Parse(response);
            if (num != 0)
            {
                numbers.Add(num);
            }
        }

        numbers.Sort();
        int sum = 0;
        int largestNum = -1;
        int smallestPositive = int.MaxValue;
        foreach (int number in numbers)
        {
            sum += number;
            if (number > largestNum)
            {
                largestNum = number;
            }
            if (number > 0 && number < smallestPositive) {
                smallestPositive = number;
            }
        }

        double average = ((float)sum)/numbers.Count;

        
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNum}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

    }
}