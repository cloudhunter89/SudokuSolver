using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class SudokuCell
    {
        public bool Validated { get; set; }

        public bool[] Markup { get; set; }

        public char Value { get; private set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public int Box { get; set; }

        public SudokuCell(char value, int symbolCount)
        {
            Value = value;
            Validated = true;
            Markup = new bool[symbolCount];
            for (int index = 0; index < symbolCount; index++)
            {
                Markup[index] = true;
            }
        }

        public void UpdateValue(char value)
        {
            Value = value;
            if (value == '-')
            {
                Validated = true;
            }
            else
            {
                Validated = false;
            }
        }
    }
}
