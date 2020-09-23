using System;

namespace RockPaperScissors
{   
  public class Program
  {
    public static void Main() 
    {
      bool notNumPlayers = true;
      string oneOrTwo = "";
      while (notNumPlayers == true)
      {
        Console.WriteLine("One or Two Players?:");
        oneOrTwo = Console.ReadLine().ToLower();
        if (oneOrTwo == "two" || oneOrTwo == "one")
        {
        notNumPlayers = false;
        } 
        else 
        {
          Console.WriteLine("enter ONE or TWO! Shheeesh");
        }
      }
      if (oneOrTwo == "two")
      {
        bool notHand = true;
        string playerOneHand = "";
        while (notHand == true)
        {
          Console.WriteLine("Enter Player One hand:");
          playerOneHand = Console.ReadLine().ToLower();
          if (playerOneHand == "rock" || playerOneHand == "paper" || playerOneHand == "scissors") 
          {
            notHand = false;
          }
          else
          {
            Console.WriteLine("Enter a real hand dummy");
          }
        }
        bool not2Hand = true;
        string playerTwoHand = "";
        while (not2Hand == true)
        {
          Console.WriteLine("Enter Player Two hand:");
          playerTwoHand = Console.ReadLine().ToLower();
          if (playerTwoHand == "rock" || playerTwoHand == "paper" || playerTwoHand == "scissors") 
          {
            not2Hand = false;
          }
          else
          {
            Console.WriteLine("Enter a real hand dummy");
          }
        }
        Console.WriteLine(Game.Play(playerOneHand,playerTwoHand));
      }
      else
      {
        bool not3Hand = true;
        string playerOneHand = "";
        while (not3Hand == true)
        {
          Console.WriteLine("Enter Player One hand:");
          playerOneHand = Console.ReadLine().ToLower();
          if (playerOneHand == "rock" || playerOneHand == "paper" || playerOneHand == "scissors") 
          {
            not3Hand = false;
          }
          else
          {
            Console.WriteLine("Enter a real hand dummy");
          }
        }
        string compHand = Game.CompPlay();
        Console.WriteLine("Computer throws "+compHand);
        Console.WriteLine(Game.Play(playerOneHand,compHand));
      }
    }
  }
}