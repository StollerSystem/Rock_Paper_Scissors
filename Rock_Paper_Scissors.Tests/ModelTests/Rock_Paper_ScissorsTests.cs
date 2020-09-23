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
  }
}