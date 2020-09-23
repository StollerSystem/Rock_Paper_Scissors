namespace RockPaperScissors
{
  public class Game
  {
    public static string Play (string p1Hand, string p2Hand)
    {
      if (p1Hand == p2Hand)
      {
        return "draw";
      } 
      // PLAYER 1
      else if (p1Hand == "rock" && p2Hand == "scissors")
      {
        return "Player One Wins";
      } 
      else if (p1Hand == "scissors" && p2Hand == "paper")
      {
        return "Player One Wins";
      }  
      else if (p1Hand == "paper" && p2Hand == "rock")
      {
        return "Player One Wins";
      }  
      // PLAYER 2
      else if (p1Hand == "rock" && p2Hand == "paper")
      {
        return "Player Two Wins";
      } 
      else if (p1Hand == "scissors" && p2Hand == "rock")
      {
        return "Player Two Wins";
      }  
      else if (p1Hand == "paper" && p2Hand == "scissors")
      {
        return "Player Two Wins";
      }              
      else
      {
        return "whatever";
      }
    }
  }
}