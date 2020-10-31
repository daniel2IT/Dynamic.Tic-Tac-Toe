using NUnit.Framework;
using System;
using System.Collections.Generic;
using XirYzaidimas;
using System.Text;

namespace Xir0Checker.UnitTests
{
   public class DiagonalLeftToRightWinnerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        //2 testai diagonale Left to Right --  X laimetojai ir 0 pralaimejimas
        [Test]
        public void checkerDiagonal_Left_To_Right_by_X_and_Y_Where_Equals_X_Win_By_Diagonal()
        {
            DiagonalLeftToRightWinner diagonalLeftToRightWinner = new DiagonalLeftToRightWinner(5, 5);
            Assert.AreEqual("X", diagonalLeftToRightWinner.checkerDiagonalLeftToRightX());
        }
        [Test]
        public void checkerDiagonal_Left_To_Right_by_X_and_Y_Where_Equals_0_Lose_By_Diagonal()
        {
            DiagonalLeftToRightWinner winner = new DiagonalLeftToRightWinner(5, 5);
            Assert.AreNotEqual("0", winner.checkerDiagonalLeftToRightX());
        }

    }
}
