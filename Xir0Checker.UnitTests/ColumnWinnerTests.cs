using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using XirYzaidimas;

namespace Xir0Checker.UnitTests
{
    public class ColumnWinnerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        //2 testai diagonale Left to Right --  X laimetojai ir 0 pralaimejimas
        [Test]
        public void checkerColumn_by_X_and_Y_Where_Equals_X_Win_By_Column()
        {
            ColumnWinner columnWinner = new ColumnWinner(5, 5);
            Assert.AreEqual("0", columnWinner.checkerColumnForX());
        }
        [Test]
        public void checkerColumn_by_X_and_Y_Where_Equals_0_Lose_By_Column()
        {
            ColumnWinner columnWinner = new ColumnWinner(7, 7);
            Assert.AreNotEqual("X", columnWinner.checkerColumnForX());
        }
    }
}
