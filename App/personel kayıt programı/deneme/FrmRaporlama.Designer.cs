namespace deneme
{
    partial class FrmRaporlama
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.Tbl_PersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.VeritabanımDataSet1 = new deneme.VeritabanımDataSet1();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Tbl_PersonelTableAdapter = new deneme.VeritabanımDataSet1TableAdapters.Tbl_PersonelTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_PersonelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VeritabanımDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // Tbl_PersonelBindingSource
            // 
            this.Tbl_PersonelBindingSource.DataMember = "Tbl_Personel";
            this.Tbl_PersonelBindingSource.DataSource = this.VeritabanımDataSet1;
            // 
            // VeritabanımDataSet1
            // 
            this.VeritabanımDataSet1.DataSetName = "VeritabanımDataSet1";
            this.VeritabanımDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Tbl_PersonelBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "deneme.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(727, 445);
            this.reportViewer1.TabIndex = 0;
            // 
            // Tbl_PersonelTableAdapter
            // 
            this.Tbl_PersonelTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRaporlama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 445);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRaporlama";
            this.Text = "FrmRaporlama";
            this.Load += new System.EventHandler(this.FrmRaporlama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tbl_PersonelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VeritabanımDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Tbl_PersonelBindingSource;
        private VeritabanımDataSet1 VeritabanımDataSet1;
        private VeritabanımDataSet1TableAdapters.Tbl_PersonelTableAdapter Tbl_PersonelTableAdapter;
    }
}