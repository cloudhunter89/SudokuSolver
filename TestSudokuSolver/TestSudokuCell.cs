using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuSolver;

namespace TestSudokuSolver
{
    [TestClass]
    public class TestSudokuCell
    {
        [TestMethod]
        public void TestSudokuCellFunctions()
        {
            int symbolCount = 3;
            char emptyCell = '-';
            SudokuCell cell = new SudokuCell(emptyCell, symbolCount);
            Assert.AreEqual(emptyCell, cell.Value);
            Assert.IsTrue(cell.Validated);
            foreach (bool possibility in cell.Markup)
            {
                Assert.IsTrue(possibility);
            }

            cell.UpdateValue('1');
            Assert.AreEqual('1', cell.Value);
            Assert.IsFalse(cell.Validated);

            cell.UpdateValue(emptyCell);
            Assert.AreEqual(emptyCell, cell.Value);
            Assert.IsTrue(cell.Validated);
        }
    }
}
