using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using XirYzaidimas;
using XirYzaidimas.Classes;

namespace Xir0Checker.UnitTests
{
    public class NoOneWonTests
    {

        [SetUp]
        public void Setup()
        {
        }

        //2 testai diagonale Left to Right --  X laimetojai ir 0 pralaimejimas
        [Test]
        public void CheckAll_X_0_Win_Equals_NeiVienasNelaimejo()
        {
            NoOneWon noOneWon = new NoOneWon(4, 4);
            Assert.AreEqual("NeiVienasNelaimejo", noOneWon.CheckAll());
        }

    }
}
