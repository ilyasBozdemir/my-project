namespace deneme
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.maskPerMaas = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioBekar = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioEvli = new System.Windows.Forms.RadioButton();
            this.comboPerSehir = new System.Windows.Forms.ComboBox();
            this.txtPerMeslek = new System.Windows.Forms.TextBox();
            this.txtPerSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPerAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPerId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnGrafikler = new System.Windows.Forms.Button();
            this.btnİstatistik = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.perIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMaasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perDurumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPersonelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.veritabanımDataSet1 = new deneme.VeritabanımDataSet1();
            this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veritabanımDataSet = new deneme.VeritabanımDataSet();
            this.tbl_PersonelTableAdapter = new deneme.VeritabanımDataSetTableAdapters.Tbl_PersonelTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.tbl_PersonelTableAdapter1 = new deneme.VeritabanımDataSet1TableAdapters.Tbl_PersonelTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanımDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanımDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.maskPerMaas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.radioBekar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.radioEvli);
            this.groupBox1.Controls.Add(this.comboPerSehir);
            this.groupBox1.Controls.Add(this.txtPerMeslek);
            this.groupBox1.Controls.Add(this.txtPerSoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPerAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPerId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 327);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Kayıt";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(10, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Personel Maaş :";
            // 
            // maskPerMaas
            // 
            this.maskPerMaas.Location = new System.Drawing.Point(105, 195);
            this.maskPerMaas.Mask = "0000";
            this.maskPerMaas.Name = "maskPerMaas";
            this.maskPerMaas.Size = new System.Drawing.Size(121, 20);
            this.maskPerMaas.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(8, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Personel Meslek";
            // 
            // radioBekar
            // 
            this.radioBekar.AutoSize = true;
            this.radioBekar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioBekar.Location = new System.Drawing.Point(173, 221);
            this.radioBekar.Name = "radioBekar";
            this.radioBekar.Size = new System.Drawing.Size(53, 17);
            this.radioBekar.TabIndex = 5;
            this.radioBekar.TabStop = true;
            this.radioBekar.Text = "Bekar";
            this.radioBekar.UseVisualStyleBackColor = true;
            this.radioBekar.CheckedChanged += new System.EventHandler(this.radioBekar_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(11, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Personel Durum";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Personel Sehir :";
            // 
            // radioEvli
            // 
            this.radioEvli.AutoSize = true;
            this.radioEvli.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radioEvli.Location = new System.Drawing.Point(105, 221);
            this.radioEvli.Name = "radioEvli";
            this.radioEvli.Size = new System.Drawing.Size(42, 17);
            this.radioEvli.TabIndex = 4;
            this.radioEvli.TabStop = true;
            this.radioEvli.Text = "Evli";
            this.radioEvli.UseVisualStyleBackColor = true;
            this.radioEvli.CheckedChanged += new System.EventHandler(this.radioEvli_CheckedChanged);
            // 
            // comboPerSehir
            // 
            this.comboPerSehir.FormattingEnabled = true;
            this.comboPerSehir.Location = new System.Drawing.Point(105, 157);
            this.comboPerSehir.Name = "comboPerSehir";
            this.comboPerSehir.Size = new System.Drawing.Size(121, 21);
            this.comboPerSehir.TabIndex = 2;
            // 
            // txtPerMeslek
            // 
            this.txtPerMeslek.Location = new System.Drawing.Point(105, 255);
            this.txtPerMeslek.Name = "txtPerMeslek";
            this.txtPerMeslek.Size = new System.Drawing.Size(121, 20);
            this.txtPerMeslek.TabIndex = 6;
            // 
            // txtPerSoyad
            // 
            this.txtPerSoyad.Location = new System.Drawing.Point(105, 127);
            this.txtPerSoyad.Name = "txtPerSoyad";
            this.txtPerSoyad.Size = new System.Drawing.Size(121, 20);
            this.txtPerSoyad.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Personel Soyad :";
            // 
            // txtPerAd
            // 
            this.txtPerAd.Location = new System.Drawing.Point(105, 88);
            this.txtPerAd.Name = "txtPerAd";
            this.txtPerAd.Size = new System.Drawing.Size(121, 20);
            this.txtPerAd.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(26, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Personel Ad:";
            // 
            // txtPerId
            // 
            this.txtPerId.Location = new System.Drawing.Point(105, 53);
            this.txtPerId.Name = "txtPerId";
            this.txtPerId.ReadOnly = true;
            this.txtPerId.Size = new System.Drawing.Size(121, 20);
            this.txtPerId.TabIndex = 0;
            this.txtPerId.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(26, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Id:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnListele);
            this.groupBox2.Controls.Add(this.btnGrafikler);
            this.groupBox2.Controls.Add(this.btnİstatistik);
            this.groupBox2.Controls.Add(this.btnTemizle);
            this.groupBox2.Controls.Add(this.btnGüncelle);
            this.groupBox2.Controls.Add(this.btnSil);
            this.groupBox2.Controls.Add(this.btnKaydet);
            this.groupBox2.Location = new System.Drawing.Point(276, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 327);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btnListele
            // 
            this.btnListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.btnListele.Location = new System.Drawing.Point(43, 13);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(155, 34);
            this.btnListele.TabIndex = 7;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnGrafikler
            // 
            this.btnGrafikler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGrafikler.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGrafikler.Location = new System.Drawing.Point(43, 247);
            this.btnGrafikler.Name = "btnGrafikler";
            this.btnGrafikler.Size = new System.Drawing.Size(155, 34);
            this.btnGrafikler.TabIndex = 6;
            this.btnGrafikler.Text = "Grafikler";
            this.btnGrafikler.UseVisualStyleBackColor = true;
            this.btnGrafikler.Click += new System.EventHandler(this.btnGrafikler_Click);
            // 
            // btnİstatistik
            // 
            this.btnİstatistik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİstatistik.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnİstatistik.Location = new System.Drawing.Point(44, 207);
            this.btnİstatistik.Name = "btnİstatistik";
            this.btnİstatistik.Size = new System.Drawing.Size(155, 34);
            this.btnİstatistik.TabIndex = 5;
            this.btnİstatistik.Text = "İstatistik";
            this.btnİstatistik.UseVisualStyleBackColor = true;
            this.btnİstatistik.Click += new System.EventHandler(this.btnİstatistik_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTemizle.Location = new System.Drawing.Point(44, 167);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(155, 34);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnGüncelle.Location = new System.Drawing.Point(44, 127);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(155, 34);
            this.btnGüncelle.TabIndex = 3;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSil.Location = new System.Drawing.Point(43, 89);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(155, 34);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKaydet.Location = new System.Drawing.Point(43, 53);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(155, 34);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(9, 356);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(746, 209);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kayıtlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIdDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaasDataGridViewTextBoxColumn,
            this.perDurumDataGridViewTextBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPersonelBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(740, 190);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // perIdDataGridViewTextBoxColumn
            // 
            this.perIdDataGridViewTextBoxColumn.DataPropertyName = "PerId";
            this.perIdDataGridViewTextBoxColumn.HeaderText = "PerId";
            this.perIdDataGridViewTextBoxColumn.Name = "perIdDataGridViewTextBoxColumn";
            // 
            // perAdDataGridViewTextBoxColumn
            // 
            this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
            this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
            this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
            // 
            // perSoyadDataGridViewTextBoxColumn
            // 
            this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
            this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
            // 
            // perSehirDataGridViewTextBoxColumn
            // 
            this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
            this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
            // 
            // perMaasDataGridViewTextBoxColumn
            // 
            this.perMaasDataGridViewTextBoxColumn.DataPropertyName = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.HeaderText = "PerMaas";
            this.perMaasDataGridViewTextBoxColumn.Name = "perMaasDataGridViewTextBoxColumn";
            // 
            // perDurumDataGridViewTextBoxColumn
            // 
            this.perDurumDataGridViewTextBoxColumn.DataPropertyName = "PerDurum";
            this.perDurumDataGridViewTextBoxColumn.HeaderText = "PerDurum";
            this.perDurumDataGridViewTextBoxColumn.Name = "perDurumDataGridViewTextBoxColumn";
            // 
            // perMeslekDataGridViewTextBoxColumn
            // 
            this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
            this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
            // 
            // tblPersonelBindingSource1
            // 
            this.tblPersonelBindingSource1.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource1.DataSource = this.veritabanımDataSet1;
            // 
            // veritabanımDataSet1
            // 
            this.veritabanımDataSet1.DataSetName = "VeritabanımDataSet1";
            this.veritabanımDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPersonelBindingSource
            // 
            this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
            this.tblPersonelBindingSource.DataSource = this.veritabanımDataSet;
            // 
            // veritabanımDataSet
            // 
            this.veritabanımDataSet.DataSetName = "VeritabanımDataSet";
            this.veritabanımDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_PersonelTableAdapter
            // 
            this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(559, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // tbl_PersonelTableAdapter1
            // 
            this.tbl_PersonelTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(44, 287);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Raporlama";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::deneme.Properties.Resources.timely_dribbble;
            this.pictureBox1.Location = new System.Drawing.Point(516, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 192);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(767, 577);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanımDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veritabanımDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPerSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPerAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPerId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioBekar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioEvli;
        private System.Windows.Forms.ComboBox comboPerSehir;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGrafikler;
        private System.Windows.Forms.Button btnİstatistik;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtPerMeslek;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox maskPerMaas;
        private System.Windows.Forms.PictureBox pictureBox1;
        private VeritabanımDataSet veritabanımDataSet;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource;
        private VeritabanımDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnListele;
        private VeritabanımDataSet1 veritabanımDataSet1;
        private System.Windows.Forms.BindingSource tblPersonelBindingSource1;
        private VeritabanımDataSet1TableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn perIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMaasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perDurumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;

    }
}

