using System;
using System.Collections.Generic;
using System.IO;

class Program
{
  static void Main(string[] args)
  {

    Journal journal = new Journal();
    bool exit = false;
    List<string> options = new List<string> {
      "1. Write a new entry",
      "2. Display the journal",
      "3. Save the journal to a file",
      "4. Load the journal from a file",
      "5. Quit",
      "Enter your choice: "
    };

    while (!exit)
    {
      foreach (string option in options)
      {
        Console.WriteLine(option);
      }
      string choice = Console.ReadLine();

      switch (choice)
      {
        case "1":
          List<string> prompts = new List<string> {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What was the best decision I made today?",
            "What would I change about today?",
            "How I can improve?"
          };

          Random randomGenerator = new Random();
          int index = randomGenerator.Next(1, 6);
          string randomPrompt = prompts[index];
          Console.WriteLine(randomPrompt);
          string response = Console.ReadLine();

          Console.Write("Today\'s mood: ");
          string mood = Console.ReadLine();

          Entry newEntry = new Entry { Date = DateTime.Now, Prompt = randomPrompt, Response = response, Mood = mood };
          journal.AddEntry(newEntry);
          break;

        case "2":
          journal.DisplayEntries();
          break;

        case "3":
          Console.WriteLine("Please, enter the file name: ");
          string fileName = Console.ReadLine();
          journal.SaveToFile(fileName);
          break;

        case "4":
          Console.WriteLine("Enter the file name: ");
          string fileNameLoad = Console.ReadLine();
          journal.LoadFromFile(fileNameLoad);
          break;

        case "5":
          exit = true;
          break;

        default:
          Console.WriteLine("Invalid choice, please try again.");
          break;
      }
    }
  }
}
