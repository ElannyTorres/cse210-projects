using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage:");
        string percentage = Console.ReadLine();
        int numPercentage = int.Parse(percentage);
        string gradeLetter = "";
        string sign = "";

        if ( numPercentage >= 90)
        {
            gradeLetter = "A";
        }
        else if ( numPercentage >= 80)
        {
            gradeLetter = "B";
        }
        else if ( numPercentage >= 70)
        {
            gradeLetter = "C";
        }
        else if ( numPercentage >= 60)
        {
            gradeLetter = "D";
        }
        else if ( numPercentage < 60)
        {
            gradeLetter = "F";
        }

        int lastDigit = numPercentage % 10;
        if (lastDigit >= 7 && gradeLetter != "A" && gradeLetter != "F")
        {
            sign = "+";
        }
        else if (lastDigit < 3 && gradeLetter != "F")
        {
            sign = "-";
        }

        Console.WriteLine($"Your grade letter is: {gradeLetter}{sign}");

        if (numPercentage >= 70)
        {
            Console.WriteLine("Congratulation! You passed!");
        }
        else
        {
            Console.Write("Best luck for next time.");
        }
    }
}
