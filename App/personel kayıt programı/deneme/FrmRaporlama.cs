using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class FrmRaporlama : Form
    {
        public FrmRaporlama()
        {
            InitializeComponent();
        }

        private void FrmRaporlama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'VeritabanımDataSet1.Tbl_Personel' table. You can move, or remove it, as needed.
            this.Tbl_PersonelTableAdapter.Fill(this.VeritabanımDataSet1.Tbl_Personel);

            this.reportViewer1.RefreshReport();
        }
    }
}
