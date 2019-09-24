using System;
using System.Collections.Generic;

class HigherLowerGame
{
  static void Main()
  {
    Console.WriteLine("Pick a number between 1-100 for me to guess.");
    int computerGuess = GuessMiddleNumber(1, 100);
    Console.WriteLine("Is your number " + computerGuess + "? (Enter Y/N)");
    string answer = Console.ReadLine();
    if (answer.ToUpper() == "Y")
    {
      Console.WriteLine("I won! Your number is: " + computerGuess);
      Console.WriteLine("Play Again? (Enter Y/N)");
      string newGame = Console.ReadLine();
      if (newGame.ToUpper() == "Y")
      {
        Main();
      } 
      else 
      {
        Console.WriteLine("Goodbye.");
      }
    } 
    else if (answer.ToUpper() == "N")
    {

    }


  }
  static int GuessMiddleNumber(int min, int max)
  {
    int halfwayNum = ((max - min)/2)+ min;
    return halfwayNum;
  }
}