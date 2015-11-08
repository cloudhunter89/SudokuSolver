using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class GridEnumerator : IEnumerator
    {
        public SudokuCell[] cells;
        
        int position = -1;

        public GridEnumerator(SudokuCell[] list)
        {
            cells = list;
        }

        public bool MoveNext()
        {
            position++;
            return (position < cells.Length);
        }

        public void Reset()
        {
            position = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public SudokuCell Current
        {
            get
            {
                try
                {
                    return cells[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}
