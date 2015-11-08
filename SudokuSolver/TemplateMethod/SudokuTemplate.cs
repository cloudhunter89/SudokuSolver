using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver.TemplateMethod
{
    abstract class SudokuTemplate
    {
        protected abstract SudokuCell SelectCell();
        protected abstract char SelectCandidateValue(SudokuCell CandidateCell);
        protected abstract 
    }
}
