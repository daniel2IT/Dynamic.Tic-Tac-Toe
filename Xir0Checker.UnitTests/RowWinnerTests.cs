using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using XirYzaidimas;


namespace Xir0Checker.UnitTests
{
    public class RowWinnerTests
    {
        [SetUp]
        public void Setup()
        {
        }


        //2 testai Eiluciu --  X laimetojai ir 0 pralaimejimas
        [Test]
        public void checkerRow_by_X_and_Y_Where_Equals_X_Win_By_Row()
        {
            RowWinner rowWinner = new RowWinner(5, 5);
            Assert.AreEqual("X", rowWinner.checkerRowForX());
        }
        [Test]
        public void checkerRow_by_X_and_Y_Where_Equals_0_Lose_By_Column()
        {
            RowWinner rowWinner = new RowWinner(5, 5);
            Assert.AreNotEqual("0", rowWinner.checkerRowForX());
        }
    }
}
