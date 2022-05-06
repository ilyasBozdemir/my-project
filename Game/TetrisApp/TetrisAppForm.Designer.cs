namespace TetrisApp
{
    partial class TetrisAppForm
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
            this.pnlGameZone = new System.Windows.Forms.Panel();
            this.pnlCurrentShape = new System.Windows.Forms.Panel();
            this.pnlNextShape = new System.Windows.Forms.Panel();
            this.lblScore = new System.Windows.Forms.Label();
            this.pnlGameZone.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlGameZone
            // 
            this.pnlGameZone.BackColor = System.Drawing.Color.White;
            this.pnlGameZone.Controls.Add(this.pnlCurrentShape);
            this.pnlGameZone.Location = new System.Drawing.Point(10, 10);
            this.pnlGameZone.Name = "pnlGameZone";
            this.pnlGameZone.Size = new System.Drawing.Size(300, 480);
            this.pnlGameZone.TabIndex = 0;
            // 
            // pnlCurrentShape
            // 
            this.pnlCurrentShape.BackColor = System.Drawing.Color.Transparent;
            this.pnlCurrentShape.Location = new System.Drawing.Point(90, 0);
            this.pnlCurrentShape.Name = "pnlCurrentShape";
            this.pnlCurrentShape.Size = new System.Drawing.Size(120, 120);
            this.pnlCurrentShape.TabIndex = 2;
            // 
            // pnlNextShape
            // 
            this.pnlNextShape.BackColor = System.Drawing.Color.White;
            this.pnlNextShape.Location = new System.Drawing.Point(330, 10);
            this.pnlNextShape.Name = "pnlNextShape";
            this.pnlNextShape.Size = new System.Drawing.Size(120, 120);
            this.pnlNextShape.TabIndex = 1;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.Location = new System.Drawing.Point(330, 173);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(72, 20);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score : 0";
            // 
            // TetrisAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 491);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pnlNextShape);
            this.Controls.Add(this.pnlGameZone);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 530);
            this.MinimumSize = new System.Drawing.Size(480, 530);
            this.Name = "TetrisAppForm";
            this.Text = "Tetris Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TetrisAppForm_KeyDown);
            this.pnlGameZone.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlGameZone;
        private System.Windows.Forms.Panel pnlNextShape;
        private System.Windows.Forms.Panel pnlCurrentShape;
        private Game game;
        private int sayac = 0;
        private System.Windows.Forms.Label lblScore;
    }
}

