using System;
using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Program
  {
    public static void Main()
    {
      bool scrabbleMaking = true;

      Console.WriteLine("Hello welcome to our BOOTY");

      while (scrabbleMaking)
      {
        Console.WriteLine("What is your word?");
        string userInput = Console.ReadLine().ToUpper();
        Word newWord = new Word(userInput);
        Console.WriteLine(newWord.GetValue());

        Console.WriteLine("Do you want to check the value of another word? Press 1, or any letter to exit");

        if (Console.ReadLine() != "1")
        {
          scrabbleMaking = false;
        }
      }
    }
  }
}
