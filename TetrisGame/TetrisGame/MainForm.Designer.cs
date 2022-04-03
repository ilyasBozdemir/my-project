namespace TetrisGame
{
    partial class MainForm
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
            this.pnlOyunAlani = new System.Windows.Forms.Panel();
            this.pnlMainPanel = new System.Windows.Forms.Panel();
            this.pnlOyunAlani.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlOyunAlani
            // 
            this.pnlOyunAlani.BackColor = System.Drawing.SystemColors.Control;
            this.pnlOyunAlani.Controls.Add(this.pnlMainPanel);
            this.pnlOyunAlani.Location = new System.Drawing.Point(0, 0);
            this.pnlOyunAlani.Name = "pnlOyunAlani";
            this.pnlOyunAlani.Size = new System.Drawing.Size(300, 480);
            this.pnlOyunAlani.TabIndex = 1;
            // 
            // pnlMainPanel
            // 
            this.pnlMainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMainPanel.Location = new System.Drawing.Point(90, 0);
            this.pnlMainPanel.Name = "pnlMainPanel";
            this.pnlMainPanel.Size = new System.Drawing.Size(120, 120);
            this.pnlMainPanel.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 491);
            this.Controls.Add(this.pnlOyunAlani);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 530);
            this.MinimumSize = new System.Drawing.Size(480, 530);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.pnlOyunAlani.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlOyunAlani;
        private System.Windows.Forms.Panel pnlMainPanel;
    }
}