namespace MineSweeperFormApp
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTimeElapsed = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.areaPanel = new System.Windows.Forms.Panel();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.button1);
            this.mainPanel.Controls.Add(this.lblTimeElapsed);
            this.mainPanel.Controls.Add(this.lblScore);
            this.mainPanel.Controls.Add(this.btnRestart);
            this.mainPanel.Controls.Add(this.areaPanel);
            this.mainPanel.Location = new System.Drawing.Point(10, 10);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(760, 827);
            this.mainPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(401, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "Mayınları göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTimeElapsed.Location = new System.Drawing.Point(650, 32);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(93, 19);
            this.lblTimeElapsed.TabIndex = 3;
            this.lblTimeElapsed.Text = "[Geçen Süre]";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(31, 32);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(52, 19);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "[Puan]";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(265, 12);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(109, 61);
            this.btnRestart.TabIndex = 1;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // areaPanel
            // 
            this.areaPanel.Location = new System.Drawing.Point(2, 90);
            this.areaPanel.Name = "areaPanel";
            this.areaPanel.Size = new System.Drawing.Size(754, 625);
            this.areaPanel.TabIndex = 0;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 859);
            this.Controls.Add(this.mainPanel);
            this.Name = "GameForm";
            this.Text = "MineSweeper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameForm_FormClosed);
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel mainPanel;
        private Button btnRestart;
        private Panel areaPanel;
        private Label lblTimeElapsed;
        private Label lblScore;
        private Button button1;
    }
}