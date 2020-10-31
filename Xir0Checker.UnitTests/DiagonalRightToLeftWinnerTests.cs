using NUnit.Framework;
using XirYzaidimas;

namespace Xir0Checker.UnitTests
{
    public class DiagonalRightToLeftWinnerTests
    {
        [SetUp]
        public void Setup()
        {
        }
    

        //2 testai diagonale  Right to Left--  X laimetojai ir 0 pralaimejimas
        [Test]
        public void checkerDiagonal_Right_To_Left_by_X_and_Y_Where_Equals_X_Win_By_Diagonal()
        {
            DiagonalRightToLeftWinner diagonalRightToLeftWinner = new DiagonalRightToLeftWinner(5, 5);
            Assert.AreEqual("X", diagonalRightToLeftWinner.checkerDiagonalRightToLeftX());
        }
        [Test]
        public void checkerDiagonal_Right_To_Left_by_X_and_Y_Where_Equals_0_Lose_By_Diagonal()
        {
            DiagonalRightToLeftWinner diagonalRightToLeft = new DiagonalRightToLeftWinner(5, 5);
            Assert.AreNotEqual("0", diagonalRightToLeft.checkerDiagonalRightToLeftX());
        }

    }
}