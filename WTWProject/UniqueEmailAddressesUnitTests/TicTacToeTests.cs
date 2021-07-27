using Microsoft.VisualStudio.TestTools.UnitTesting;
using WTWProject;

namespace UniqueEmailAddressesUnitTests
{
    [TestClass]

    public class TicTacToeTests
    {
        #region PlayerOne
        [TestMethod]
        public void GameBoard_OfSize3_PlayerOneHasThreeInARow_ResultsInPlayerOneWin()
        {
            // Arrange
            var expectedResult = 1;
            int player = 1;
            ITicTacToe game = new NDimensionalTicTacToe(3);
            game.PlacePiece(0, 0, player);
            game.PlacePiece(0, 1, player);

            // Act
            int result = game.PlacePiece(0, 2, player);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void GameBoard_OfSize3_PlayerOneHasThreeInACol_ResultsInPlayerOneWin()
        {
            // Arrange
            var expectedResult = 1;
            int player = 1;
            ITicTacToe game = new NDimensionalTicTacToe(3);
            game.PlacePiece(0, 1, player);
            game.PlacePiece(1, 1, player);

            // Act
            int result = game.PlacePiece(2, 1, player);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void GameBoard_OfSize3_PlayerOneHasThreeInForwardDiagonal_ResultsInPlayerOneWin()
        {
            // Arrange
            var expectedResult = 1;
            int player = 1;
            ITicTacToe game = new NDimensionalTicTacToe(3);
            game.PlacePiece(0, 0, player);
            game.PlacePiece(1, 1, player);

            // Act
            int result = game.PlacePiece(2, 2, player);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void GameBoard_OfSize3_PlayerOneHasThreeInBackwardDiagonal_ResultsInPlayerOneWin()
        {
            // Arrange
            var expectedResult = 1;
            int player = 1;
            ITicTacToe game = new NDimensionalTicTacToe(3);
            game.PlacePiece(2, 0, player);
            game.PlacePiece(1, 1, player);

            // Act
            int result = game.PlacePiece(0, 2, player);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
        #endregion PlayerOne

        #region PlayerTwo
        [TestMethod]
        public void GameBoard_OfSize3_PlayerTwoHasThreeInARow_ResultsInPlayerOneWin()
        {
            // Arrange
            var expectedResult = 2;
            int player = 2;
            ITicTacToe game = new NDimensionalTicTacToe(3);
            game.PlacePiece(0, 0, player);
            game.PlacePiece(0, 1, player);

            // Act
            int result = game.PlacePiece(0, 2, player);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void GameBoard_OfSize3_PlayerTwoHasThreeInACol_ResultsInPlayerOneWin()
        {
            // Arrange
            var expectedResult = 2;
            int player = 2;
            ITicTacToe game = new NDimensionalTicTacToe(3);
            game.PlacePiece(0, 1, player);
            game.PlacePiece(1, 1, player);

            // Act
            int result = game.PlacePiece(2, 1, player);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void GameBoard_OfSize3_PlayerTwoHasThreeInForwardDiagonal_ResultsInPlayerOneWin()
        {
            // Arrange
            var expectedResult = 2;
            int player = 2;
            ITicTacToe game = new NDimensionalTicTacToe(3);
            game.PlacePiece(0, 0, player);
            game.PlacePiece(1, 1, player);

            // Act
            int result = game.PlacePiece(2, 2, player);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void GameBoard_OfSize3_PlayerTwoHasThreeInBackwardDiagonal_ResultsInPlayerOneWin()
        {
            // Arrange
            var expectedResult = 2;
            int player = 2;
            ITicTacToe game = new NDimensionalTicTacToe(3);
            game.PlacePiece(2, 0, player);
            game.PlacePiece(1, 1, player);

            // Act
            int result = game.PlacePiece(0, 2, player);

            // Assert
            Assert.AreEqual(expectedResult, result);
        }
        #endregion PlayerTwo
    }
}
