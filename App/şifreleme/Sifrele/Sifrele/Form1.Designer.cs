namespace Sifrele
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSifrele = new System.Windows.Forms.Button();
            this.txtsifrele = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaseSifre = new System.Windows.Forms.TextBox();
            this.txtmd5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsha1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSifreCoz = new System.Windows.Forms.Button();
            this.txtBaseDesifre = new System.Windows.Forms.TextBox();
            this.txtsifrecoz = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSifrele);
            this.groupBox1.Controls.Add(this.txtsifrele);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBaseSifre);
            this.groupBox1.Controls.Add(this.txtmd5);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtsha1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(5, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 314);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnSifrele
            // 
            this.btnSifrele.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnSifrele.Location = new System.Drawing.Point(77, 90);
            this.btnSifrele.Name = "btnSifrele";
            this.btnSifrele.Size = new System.Drawing.Size(162, 43);
            this.btnSifrele.TabIndex = 0;
            this.btnSifrele.Text = "Şifrele";
            this.btnSifrele.UseVisualStyleBackColor = true;
            this.btnSifrele.Click += new System.EventHandler(this.btnSifrele_Click);
            // 
            // txtsifrele
            // 
            this.txtsifrele.Location = new System.Drawing.Point(77, 56);
            this.txtsifrele.Name = "txtsifrele";
            this.txtsifrele.Size = new System.Drawing.Size(162, 23);
            this.txtsifrele.TabIndex = 1;
            this.txtsifrele.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(73, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Şifrelencek Metni Girin :";
            // 
            // txtBaseSifre
            // 
            this.txtBaseSifre.Location = new System.Drawing.Point(22, 272);
            this.txtBaseSifre.Name = "txtBaseSifre";
            this.txtBaseSifre.ReadOnly = true;
            this.txtBaseSifre.Size = new System.Drawing.Size(250, 23);
            this.txtBaseSifre.TabIndex = 1;
            this.txtBaseSifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmd5
            // 
            this.txtmd5.Location = new System.Drawing.Point(22, 162);
            this.txtmd5.Name = "txtmd5";
            this.txtmd5.ReadOnly = true;
            this.txtmd5.Size = new System.Drawing.Size(250, 23);
            this.txtmd5.TabIndex = 1;
            this.txtmd5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Corbel", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(106, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "BASE64 şifre";
            // 
            // txtsha1
            // 
            this.txtsha1.Location = new System.Drawing.Point(22, 207);
            this.txtsha1.Name = "txtsha1";
            this.txtsha1.ReadOnly = true;
            this.txtsha1.Size = new System.Drawing.Size(250, 23);
            this.txtsha1.TabIndex = 1;
            this.txtsha1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Corbel", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(130, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "SHA1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Corbel", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(130, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Md5";
            // 
            // btnSifreCoz
            // 
            this.btnSifreCoz.Font = new System.Drawing.Font("Corbel", 12F);
            this.btnSifreCoz.Location = new System.Drawing.Point(69, 94);
            this.btnSifreCoz.Name = "btnSifreCoz";
            this.btnSifreCoz.Size = new System.Drawing.Size(162, 39);
            this.btnSifreCoz.TabIndex = 3;
            this.btnSifreCoz.Text = "Şifreyi Çöz";
            this.btnSifreCoz.UseVisualStyleBackColor = true;
            this.btnSifreCoz.Click += new System.EventHandler(this.btnSifreCoz_Click);
            // 
            // txtBaseDesifre
            // 
            this.txtBaseDesifre.Location = new System.Drawing.Point(26, 207);
            this.txtBaseDesifre.Name = "txtBaseDesifre";
            this.txtBaseDesifre.ReadOnly = true;
            this.txtBaseDesifre.Size = new System.Drawing.Size(250, 23);
            this.txtBaseDesifre.TabIndex = 1;
            this.txtBaseDesifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtsifrecoz
            // 
            this.txtsifrecoz.Location = new System.Drawing.Point(69, 53);
            this.txtsifrecoz.Name = "txtsifrecoz";
            this.txtsifrecoz.Size = new System.Drawing.Size(162, 23);
            this.txtsifrecoz.TabIndex = 4;
            this.txtsifrecoz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Corbel", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(108, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "BASE64 deşifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(108, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "BASE64 için ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSifreCoz);
            this.groupBox2.Controls.Add(this.txtBaseDesifre);
            this.groupBox2.Controls.Add(this.txtsifrecoz);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(335, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 314);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(663, 395);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Şİfrele";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSifrele;
        private System.Windows.Forms.TextBox txtsifrele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaseSifre;
        private System.Windows.Forms.TextBox txtmd5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsha1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSifreCoz;
        private System.Windows.Forms.TextBox txtBaseDesifre;
        private System.Windows.Forms.TextBox txtsifrecoz;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

