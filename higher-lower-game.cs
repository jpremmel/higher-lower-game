using System;
public class Program
{
  public static void Main()
  {
    Console.WriteLine("Pick a number between 1-100 for me to guess.");
    int min = 1;
    int max = 100;
    GuessMiddleNumber(min, max);
  }
  static void GuessMiddleNumber(int min, int max)
  // GuessMiddleNumber is a method for calculating the users number. We added the branching statements here because we need to repeat this series of questions until the user answers yes
  {
    int halfwayNum = ((max - min)/2)+ min;
    Console.WriteLine("Is your number " + halfwayNum + "? (Enter Y/N)");

    string answer = Console.ReadLine();
    if (answer.ToUpper() == "Y" || answer.ToUpper() == "YES")
    {
      Console.WriteLine("I won! Your number is: " + halfwayNum);
      Console.WriteLine("Play Again? (Enter Y/N)");
      string newGame = Console.ReadLine();
      if (newGame.ToUpper() == "Y" || newGame.ToUpper() == "YES")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Goodbye.");
      }
    }
    else
    {
      Console.WriteLine("Is your number higher or lower? (Enter H/L)");
      string response = Console.ReadLine();
      if (response.ToUpper() == "H" || response.ToUpper() == "HIGHER")
      {
        min = halfwayNum;
        GuessMiddleNumber(min, max);
      }
      else if (response.ToUpper() == "L" || response.ToUpper() == "LOWER")
      {
        max = halfwayNum;
        GuessMiddleNumber(min, max);
      }
    }
  }
}