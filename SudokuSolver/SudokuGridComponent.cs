using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class SudokuGridComponent
    {
        public List<SudokuCell> Cells { get; private set; }

        public int Dimension { get; private set; }

        public SudokuGridComponent(int dimension)
        {
            Dimension = dimension;
            Cells = new List<SudokuCell>();
        }

        public bool AddCell(SudokuCell newCell)
        {
            bool cellAdded = Validate(newCell);
            if (cellAdded)
            {
                Cells.Add(newCell);
            }

            return cellAdded;
        }

        public void UpdateCell(int cell, char newValue)
        {
            Cells[cell].UpdateValue(newValue);
        }

        public SudokuCell GetCell(int cell)
        {
            return Cells[cell];
        }

        public SudokuCell this[int index]
        {
            get { return Cells[index]; }
            // set { Cells[index] = value; }
        }

        public bool Validate()
        {
            bool isValid = true;

            foreach (SudokuCell cell in Cells)
            {
                if (!cell.Validated)
                {
                    cell.Validated = Validate(cell);
                }
                isValid &= cell.Validated;
            }

            return isValid;
        }
            
        private bool Validate(SudokuCell cellToValidate)
        {
            bool isValid = true;

            foreach (SudokuCell cell in Cells)
            {
                if (!cellToValidate.Equals(cell))
                {
                    isValid &= cellToValidate.Value != cell.Value;
                }
            }

            return isValid;
        }
    }
}
