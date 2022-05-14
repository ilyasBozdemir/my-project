namespace SudokuFormApp
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            this.pnlSudoku = new System.Windows.Forms.Panel();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.btnShowSolution = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pnlSudoku
            // 
            this.pnlSudoku.Location = new System.Drawing.Point(10, 10);
            this.pnlSudoku.Name = "pnlSudoku";
            this.pnlSudoku.Size = new System.Drawing.Size(400, 400);
            this.pnlSudoku.TabIndex = 0;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNewGame.Location = new System.Drawing.Point(416, 53);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(75, 47);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "Yeni Oyun";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTimeElapsed.Location = new System.Drawing.Point(442, 9);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(92, 14);
            this.lblTimeElapsed.TabIndex = 2;
            this.lblTimeElapsed.Text = "[lblTimeElapsed]";
            // 
            // btnShowSolution
            // 
            this.btnShowSolution.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnShowSolution.Location = new System.Drawing.Point(416, 173);
            this.btnShowSolution.Name = "btnShowSolution";
            this.btnShowSolution.Size = new System.Drawing.Size(75, 45);
            this.btnShowSolution.TabIndex = 4;
            this.btnShowSolution.Text = "Çözümü Göster";
            this.btnShowSolution.UseVisualStyleBackColor = true;
            this.btnShowSolution.Click += new System.EventHandler(this.btnShowSolution_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCheck.Location = new System.Drawing.Point(416, 116);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 47);
            this.btnCheck.TabIndex = 5;
            this.btnCheck.Text = "Kontrol Et";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 456);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnShowSolution);
            this.Controls.Add(this.lblTimeElapsed);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.pnlSudoku);
            this.MaximumSize = new System.Drawing.Size(571, 495);
            this.MinimumSize = new System.Drawing.Size(571, 495);
            this.Name = "GameForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSudoku;
        private System.Windows.Forms.Label lblTimeElapsed;
        private System.Windows.Forms.Button btnShowSolution;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCheck;
    }
}

