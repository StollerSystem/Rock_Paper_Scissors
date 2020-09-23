using System;

namespace RockPaperScissors
{
  public class Game
  {
    public static string Play (string p1Hand, string p2Hand)
    {
      // PLAYER 1
      if (p1Hand == "rock" && p2Hand == "scissors" || p1Hand == "scissors" && p2Hand == "paper" || p1Hand == "paper" && p2Hand == "rock")
      {
        return "Player One Wins";
      } 
      // PLAYER 2
      else if (p1Hand == "rock" && p2Hand == "paper" || p1Hand == "scissors" && p2Hand == "rock" || p1Hand == "paper" && p2Hand == "scissors")
      {
        return "Player Two Wins";
      }       
      else
      {
        return "draw";
      }
    }

    public static string CompPlay ()
    {
      string[] hands = {"rock", "scissors", "paper"};
      Random random = new Random();
      int ranNum = random.Next(3);
      return hands[ranNum];
    }
  }
}