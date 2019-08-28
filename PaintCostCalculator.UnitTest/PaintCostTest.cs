using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintCostCalculator.UnitTest
{
    [TestFixture]
    public class PaintCostTest
    {
        static object[] GrillCases={
            new object[] { new PaintCost(true, true, true, new List<Room> { new Room(12, 12, 4, 2), new Room(12, 13, 3, 1) }), 126 },
            new object[] { new PaintCost(false, false, true, new List<Room> { new Room(22, 23, 2, 1), new Room(24, 25, 4, 2) ,new Room(25, 25, 2, 1), new Room(12, 15, 1, 1)}), 162 },
            new object[] { new PaintCost(false, false, true, new List<Room> { new Room(14, 14, 2, 1), new Room(8, 9, 4, 2), new Room(25, 12, 2, 1)}), 144 }
        };

        static object[] WallCases ={
            new object[] { new PaintCost(true, true, true, new List<Room> { new Room(12, 12, 4, 2), new Room(12, 13, 3, 1) }), 10143 },
            new object[] { new PaintCost(false, false, true, new List<Room> { new Room(22, 23, 2, 1), new Room(24, 25, 4, 2) ,new Room(25, 25, 2, 1), new Room(12, 15, 1, 1)}), 45560 },
            new object[] { new PaintCost(false, false, true, new List<Room> { new Room(14, 14, 2, 1), new Room(8, 9, 4, 2), new Room(25, 12, 2, 1)}), 20512 }
        };

        static object[] CellingCases ={
             new object[] { new PaintCost(true, true, true, new List<Room> { new Room(12, 12, 4, 2), new Room(12, 13, 3, 1) }), 3000 },
            new object[] { new PaintCost(false, false, true, new List<Room> { new Room(22, 23, 2, 1), new Room(24, 25, 4, 2) ,new Room(25, 25, 2, 1), new Room(12, 15, 1, 1)}), 22932 },
            new object[] { new PaintCost(false, false, true, new List<Room> { new Room(14, 14, 2, 1), new Room(8, 9, 4, 2), new Room(25, 12, 2, 1)}), 6816 }
        };

        static object[] TotalCases ={
            new object[] { new PaintCost(true, true, true, new List<Room> { new Room(12, 12, 4, 2), new Room(12, 13, 3, 1) }), 13269 },
            new object[] { new PaintCost(false, false, true, new List<Room> { new Room(22, 23, 2, 1), new Room(24, 25, 4, 2) ,new Room(25, 25, 2, 1), new Room(12, 15, 1, 1)}), 68654 },
            new object[] { new PaintCost(false, false, true, new List<Room> { new Room(14, 14, 2, 1), new Room(8, 9, 4, 2), new Room(25, 12, 2, 1)}), 27472 }
        };
        

        [Test, TestCaseSource("CellingCases")]
        public void Calculate_CellingCost_ReturnsTotalCellingCost(PaintCost paint, double expected)
        {
            Assert.That(paint.CeilingCost, Is.EqualTo(expected));
        }
        [Test, TestCaseSource("GrillCases")]
        public void Calculate_GrillCost_ReturnsTotalGrillCost(PaintCost paint, double expected)
        {
            Assert.That(paint.GrillCost, Is.EqualTo(expected));
        }
        [Test, TestCaseSource("WallCases")]
        public void Calculate_WallCost_ReturnsTotalWallCost(PaintCost paint, double expected)
        {
            Assert.That(paint.WallCost, Is.EqualTo(expected));
        }
        [Test, TestCaseSource("TotalCases")]
        public void Calculate_TotalCost_ReturnsTotalCost(PaintCost paint, double expected)
        {
            Assert.That(paint.TotalCost, Is.EqualTo(expected));
        }

    }
}
