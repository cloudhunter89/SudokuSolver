using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class SudokuGrid : IEnumerable
    {
        public List<SudokuGridComponent> Rows { get; set; }
        public List<SudokuGridComponent> Columns { get; set; }
        public List<SudokuGridComponent> Boxes { get; set; }
        public int Dimension { get; private set; }
        public char[] Symbols { get; private set; }

        public SudokuGrid(int dimension, string symbols, string[] rows)
        {
            Dimension = dimension;
            string[] tempSymbolList = symbols.Split(' ');
            Symbols = new char[Dimension + 1]; // allow for holding the symbol for an empty cell '-'
            Symbols[0] = '-';

            for (int index = 1; index < Dimension; ++index)
            {
                Symbols[index] = tempSymbolList[index - 1][0];
            }

            for (int row = 0; row < Dimension; row++)
            {
                for (int column = 0; column < Dimension; column++)
                {
                    for (int box = 0; box < Math.Sqrt(Dimension); box++)
                    {
                        SudokuCell cell = new SudokuCell(rows[row][column * 2], Dimension);
                        cell.Row = row;
                        cell.Column = column;
                        cell.Box = box;
                        AddCell(cell);
                    }
                }
            }
        }

        protected void AddCell(SudokuCell cellToAdd)
        {
            SudokuGridComponent row = GetRow(cellToAdd.Row);
            row.AddCell(cellToAdd);
            SudokuGridComponent column = GetRow(cellToAdd.Column);
            column.AddCell(cellToAdd);
            SudokuGridComponent box = GetRow(cellToAdd.Box);
            box.AddCell(cellToAdd);

        }

        public SudokuGridComponent GetColumn(int column)
        {
            return Columns[column];
        }

        public SudokuGridComponent GetRow(int row)
        {
            return Columns[row];
        }

        public SudokuGridComponent GetBox(int box)
        {
            return Columns[box];
        }

        public GridEnumerator GetEnumerator()
        {
            List<SudokuCell> allRows = new List<SudokuCell>();
            foreach (SudokuGridComponent row in Rows)
            {
                allRows.AddRange(row.Cells);
            }
            return new GridEnumerator(allRows.ToArray());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }
    }
}
