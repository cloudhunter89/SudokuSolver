using System;
using SudokuSolver;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestSudokuSolver
{
    [TestClass]
    public class TestSudokuGrid
    {
        static int testDimension1 = 9;
        static string testSymbols1 = "1 2 3 4 5 6 7 8 9";
        static string[] testPuzzle1 =
        {
            "4 9 - 1 3 6 7 - 8",
            "- 6 3 5 - - - 9 -",
            "5 - - - 2 9 3 6 4",
            "- 2 - 3 1 - - 4 -",
            "- 7 4 - - - 2 1 -",
            "- - 1 - 6 4 - 8 -",
            "1 8 6 9 - - - 2 5",
            "- 4 - - 5 1 8 3 -",
            "3 - 9 4 8 - - 7 -"
        };

        static int testInvalidDimension = 5;
        [TestMethod]
        public void TestConstructor()
        {
            SudokuGrid testGrid = new SudokuGrid(testDimension1, testSymbols1, testPuzzle1);
            for (int i = 0; i < testDimension1; i++)
            {
                SudokuGridComponent row = testGrid.GetRow(i);
                SudokuGridComponent column = testGrid.GetColumn(i);
                SudokuGridComponent box = testGrid.GetBox(i);
                for (int j = 0; j < testDimension1; j++)
                {
                    Assert.AreEqual(testPuzzle1[i][j * 2], row[j].Value);
                    Assert.AreEqual(testPuzzle1[j][i * 2], column[j].Value);
                    int r = 3 * (i / 3) + (j / 3);
                    int c =  ((j % 3) + ((i % 3) * 3)) * 2;
                    Assert.AreEqual(testPuzzle1[r][c], box[j].Value);
                }
            }

            for (int col = 0; col < testDimension1; col++)
            {
                SudokuGridComponent column = testGrid.GetRow(col);
                for (int index = 0; index < testDimension1; index++)
                {
                }
            }
        }
    }
}
