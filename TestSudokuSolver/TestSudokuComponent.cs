using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SudokuSolver;

namespace TestSudokuSolver
{
    [TestClass]
    public class TestSudokuComponent
    {
        [TestMethod]
        public void TestComponentMethods()
        {
            int dimension = 9;
            SudokuGridComponent row = new SudokuGridComponent(dimension);
            Assert.IsNotNull(row);
            Assert.IsNotNull(row.Cells);
            Assert.AreEqual(dimension, row.Dimension);

            for (int i = 0; i < dimension; i++)
            {
                row.AddCell(new SudokuCell((char)('1' + i), dimension));
            }

            Assert.IsTrue(row.Validate());

            row.Cells[1].UpdateValue('-');
            Assert.IsTrue(row.Validate());

            row.Cells[2].UpdateValue((char)(dimension + '0'));
            Assert.IsFalse(row.Validate());

            row[8].UpdateValue('2');
            Assert.IsTrue(row.Validate());
        }
    }
}
