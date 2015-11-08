namespace SudokuSolver
{
    partial class SudokuSolverGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openPuzzleFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveSolutionFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openPuzzleBtn = new System.Windows.Forms.Button();
            this.saveSolutionBtn = new System.Windows.Forms.Button();
            this.solveBtn = new System.Windows.Forms.Button();
            this.speedControl = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.speedControl)).BeginInit();
            this.SuspendLayout();
            // 
            // saveSolutionFileDialog
            // 
            this.saveSolutionFileDialog.DefaultExt = "txt";
            // 
            // openPuzzleBtn
            // 
            this.openPuzzleBtn.Location = new System.Drawing.Point(217, 13);
            this.openPuzzleBtn.Name = "openPuzzleBtn";
            this.openPuzzleBtn.Size = new System.Drawing.Size(75, 23);
            this.openPuzzleBtn.TabIndex = 0;
            this.openPuzzleBtn.Text = "Open Puzzle";
            this.openPuzzleBtn.UseVisualStyleBackColor = true;
            // 
            // saveSolutionBtn
            // 
            this.saveSolutionBtn.Location = new System.Drawing.Point(298, 12);
            this.saveSolutionBtn.Name = "saveSolutionBtn";
            this.saveSolutionBtn.Size = new System.Drawing.Size(88, 23);
            this.saveSolutionBtn.TabIndex = 1;
            this.saveSolutionBtn.Text = "Save Solution";
            this.saveSolutionBtn.UseVisualStyleBackColor = true;
            // 
            // solveBtn
            // 
            this.solveBtn.Location = new System.Drawing.Point(12, 12);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(75, 23);
            this.solveBtn.TabIndex = 2;
            this.solveBtn.Text = "Solve";
            this.solveBtn.UseVisualStyleBackColor = true;
            // 
            // speedControl
            // 
            this.speedControl.Location = new System.Drawing.Point(93, 13);
            this.speedControl.Name = "speedControl";
            this.speedControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.speedControl.Size = new System.Drawing.Size(118, 45);
            this.speedControl.TabIndex = 3;
            // 
            // SudokuSolverGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 330);
            this.Controls.Add(this.speedControl);
            this.Controls.Add(this.solveBtn);
            this.Controls.Add(this.saveSolutionBtn);
            this.Controls.Add(this.openPuzzleBtn);
            this.Name = "SudokuSolverGui";
            this.Text = "Sudoku Solver";
            ((System.ComponentModel.ISupportInitialize)(this.speedControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openPuzzleFileDialog;
        private System.Windows.Forms.SaveFileDialog saveSolutionFileDialog;
        private System.Windows.Forms.Button openPuzzleBtn;
        private System.Windows.Forms.Button saveSolutionBtn;
        private System.Windows.Forms.Button solveBtn;
        private System.Windows.Forms.TrackBar speedControl;
    }
}

