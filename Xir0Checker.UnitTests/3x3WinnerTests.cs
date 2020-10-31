using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using XirYzaidimas;
using XirYzaidimas.Classes;

namespace Xir0Checker.UnitTests
{
    public class _3x3WinnerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        //2 testai diagonale Left to Right --  X laimetojai ir 0 pralaimejimas
        [Test]
        public void checker3x3_by_X_and_Y_Where_Equals_x_Winner_By_All_Rules()
        {
            _3x3Winner _3X3Winner = new _3x3Winner(4, 4, "X");
            Assert.AreEqual("X", _3X3Winner.check1());
        }
  
     

    }
}
