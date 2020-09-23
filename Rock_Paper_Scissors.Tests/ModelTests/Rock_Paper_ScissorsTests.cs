using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors;

namespace Rock_Paper_Scissors.Tests
{
  [TestClass]
  public class RockPaperScissorsTests
  {

    [TestMethod]
    public void Game_BothChooseRock_Draw()
    {
      //Arrange

      //Act      
      string capture = Game.Play("rock","rock");
      //Assert
      Assert.AreEqual("draw", capture);
    }

    [TestMethod]
    public void Game_BothChoosePaperDraw()
    {
      //Arrange

      //Act      
      string capture = Game.Play("paper","paper");
      //Assert
      Assert.AreEqual("draw", capture);
    }

    [TestMethod]
    public void Game_BothChooseScissors_Draw()
    {
      //Arrange

      //Act      
      string capture = Game.Play("scissors","scissors");
      //Assert
      Assert.AreEqual("draw", capture);
    }

    [TestMethod]
    public void Game_P1RockAndP2Scissors_P1Wins()
    {
      //Arrange

      //Act      
      string capture = Game.Play("rock","scissors");
      //Assert
      Assert.AreEqual("Player One Wins", capture);
    }

    [TestMethod]
    public void Game_P1ScissorsAndP2Paper_P1Wins()
    {
      //Arrange

      //Act      
      string capture = Game.Play("scissors","paper");
      //Assert
      Assert.AreEqual("Player One Wins", capture);
    }

    [TestMethod]
    public void Game_P1PaperAndP2Rock_P1Wins()
    {
      //Arrange

      //Act      
      string capture = Game.Play("paper","rock");
      //Assert
      Assert.AreEqual("Player One Wins", capture);
    }

    [TestMethod]
    public void Game_P1RockAndP2Paper_P2Wins()
    {
      //Arrange

      //Act      
      string capture = Game.Play("rock","paper");
      //Assert
      Assert.AreEqual("Player Two Wins", capture);
    }

    [TestMethod]
    public void Game_P1ScissorsAndP2Rock_P2Wins()
    {
      //Arrange

      //Act      
      string capture = Game.Play("scissors","rock");
      //Assert
      Assert.AreEqual("Player Two Wins", capture);
    }
    
    [TestMethod]
    public void Game_P1PaperAndP2Scissors_P2Wins()
    {
      //Arrange

      //Act      
      string capture = Game.Play("paper","scissors");
      //Assert
      Assert.AreEqual("Player Two Wins", capture);
    }
  }
}