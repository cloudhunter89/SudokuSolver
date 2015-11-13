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
        private List<SudokuGridComponent> m_rows;
        private List<SudokuGridComponent> m_columns;
        private List<SudokuGridComponent> m_boxes;
        public int Dimension { get; private set; }
        public char[] Symbols { get; private set; }

        public SudokuGrid(int dimension, string symbols, string[] rows)
        {
            int dimensionRoot = (int)Math.Sqrt(dimension);
            if (dimensionRoot * dimensionRoot != dimension)
            {
                throw new ArgumentException("Dimension of the grid must be a perfect square");
            }

            Dimension = dimension;
            string[] tempSymbolList = symbols.Split(' ');
            Symbols = new char[Dimension + 1]; // allow for holding the symbol for an empty cell '-'
            Symbols[0] = '-';
            InitComponents(rows);

            for (int index = 1; index <= Dimension; ++index)
            {
                Symbols[index] = tempSymbolList[index - 1][0];
            }
        }

        protected void AddCell(SudokuCell cellToAdd)
        {
            m_rows[cellToAdd.Row].AddCell(cellToAdd);
            m_columns[cellToAdd.Column].AddCell(cellToAdd);
            m_boxes[cellToAdd.Box].AddCell(cellToAdd);

        }

        protected void InitComponents(string[] rows)
        {
            m_columns = new List<SudokuGridComponent>();
            m_boxes = new List<SudokuGridComponent>();
            m_rows = new List<SudokuGridComponent>();

            for (int size = 0; size < Dimension; size++)
            {
                m_rows.Add(new SudokuGridComponent(Dimension));
                m_boxes.Add(new SudokuGridComponent(Dimension));
                m_columns.Add(new SudokuGridComponent(Dimension));
            }

            for (int row = 0; row < Dimension; row++)
            {
                for (int column = 0; column < Dimension; column++)
                {
                    SudokuCell cell = new SudokuCell(rows[row][column * 2], Dimension);
                    cell.Row = row;
                    cell.Column = column;
                    cell.Box = ((int)Math.Sqrt(Dimension) * (row / (int)Math.Sqrt(Dimension)) + column / (int)Math.Sqrt(Dimension));
                    AddCell(cell);
                }
            }
        }

        public SudokuGridComponent GetColumn(int column)
        {
            return m_columns[column];
        }

        public SudokuGridComponent GetRow(int row)
        {
            return m_rows[row];
        }

        public SudokuGridComponent GetBox(int box)
        {
            return m_boxes[box];
        }

        public static int GetBoxOrder(int dimension, int row, int col)
        {
            int boxEntry = 0;
            int dimensionRoot = (int)Math.Sqrt(dimension);
            boxEntry = (col % dimensionRoot) + ((row % dimensionRoot) * dimensionRoot);
            return boxEntry; 
        }

        public static int GetBoxOrder(SudokuCell cell)
        {
            int boxEntry = 0;
            int col = cell.Column;
            int row = cell.Row;
            int dimensionRoot = (int)Math.Sqrt(cell.Markup.Count());
            boxEntry = (col % dimensionRoot) + (row % dimensionRoot) * dimensionRoot;
            return boxEntry;
        }

        public GridEnumerator GetEnumerator()
        {
            List<SudokuCell> allRows = new List<SudokuCell>();
            foreach (SudokuGridComponent row in m_rows)
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
