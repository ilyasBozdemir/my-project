using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testMatrix
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            deneyim = new SudokuDeneyim();
        }
        private SudokuDeneyim deneyim;
        public SudokuDeneyim Deneyim()
        {
            if (deneyim.ToString() == null)//hiç bir tusa basılmadıysa yani .d
                deneyim = SudokuDeneyim.Null;
            return deneyim;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            deneyim = SudokuDeneyim.Acemi;
            this.Close();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            deneyim = SudokuDeneyim.Orta;
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            deneyim = SudokuDeneyim.Zor;
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            deneyim = SudokuDeneyim.Uzman;
            this.Close();
        }
    }
}
