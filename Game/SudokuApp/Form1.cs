using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testMatrix
{
    public partial class Form1 : Form
    {
        private TextBox t0, t1, t2, t3, t4, t5, t6, t7, t8;
        private TextBox[,] TxtMatrix;
        private TextBox[,] textBoxsDatas;
        private Control ParentControl;
        private Color backColor = SystemColors.GradientInactiveCaption;
        Panel[] cells = new Panel[3];
        enum State { Row, Column }
        public Form1()
        {
            InitializeComponent();
            TxtMatrix = new TextBox[9, 9];
            textBoxsDatas = new TextBox[9, 9];
            ParentControl = new Control();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadControls();
            MatrixOnLoad();
        }
        private void LoadControls()
        {
            int sayi = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sayi++;
                    pnlSudoku.Controls.Add(PanelCell($"P{j}_{i}", new Point(i * 65, j * 65)));
                }
            }
        }
        Panel PanelCell(string name, Point point)
        {
            Panel MainPanel = new Panel();
            MainPanel.Size = new Size(60, 60);
            MainPanel.Location = point;
            MainPanel.Name = name;
            TextBox[,] txt = new TextBox[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    txt[i, j] = new TextBox();
                    txt[i, j].Location = new Point(i * 20, j * 20);
                    txt[i, j].Size = new Size(20, 20);
                    txt[i, j].MaxLength = 1;
                    txt[i, j].TextAlign = HorizontalAlignment.Center;
                    txt[i, j].BackColor = backColor;
                    txt[i, j].ForeColor = Color.Black;
                    txt[i, j].Name = $"T{j}_{i}";
                    txt[i, j].TabStop = false;
                    txt[i, j].KeyPress += txt_KeyPress;
                    txt[i, j].KeyDown += txt_KeyDown;
                    txt[i, j].MouseMove += txt_MouseMove;
                    txt[i, j].MouseLeave += txt_MouseLeave;
                    MainPanel.Controls.Add(txt[i, j]);
                }
            }
            return MainPanel;
        }
        private void txt_MouseLeave(object sender, EventArgs e)
        {
            for (int i = 0; i <= TxtMatrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= TxtMatrix.GetUpperBound(1); j++)
                {

                    TxtMatrix[i, j].BackColor = backColor;
                }
            }
        }
        private SudokuDeneyim deneyim;
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            deneyim = f2.Deneyim();
            StartGame();
        }
        private void StartGame()
        {

        }

        public string MatrixToPanelName(int i, int j)
        {
            string PanelName = "";
            if (i < 3) //ilk satır için :d
            {
                if (j < 3) // 0_0 Paneli
                    PanelName = "0_0";
                else if (j >= 3 && j < 6) // 0_1 Paneli
                    PanelName = "0_1";
                else if (j >= 6 && j < 9) // 0_2 Paneli
                    PanelName = "0_2";
            }
            else if (i >= 3 && i < 6) //ikinci satır için :d
            {
                if (j < 3) // 1_0 Paneli
                    PanelName = "1_0";
                else if (j >= 3 && j < 6) // 1_1 Paneli
                    PanelName = "1_1";
                else if (j >= 6 && j < 9) // 1_2 Paneli
                    PanelName = "1_2";
            }
            else if (i >= 6 && i < 9) //üçüncü satır için :d
            {
                if (j < 3) // 2_0 Paneli
                    PanelName = "2_0";
                else if (j >= 3 && j < 6) // 2_1 Paneli
                    PanelName = "2_1";
                else if (j >= 6 && j < 9) // 2_2 Paneli
                    PanelName = "2_2";
            }

            return $"P{PanelName}";
        }
        private void txt_MouseMove(object sender, MouseEventArgs e)
        {
            ControlToMatrix((TextBox) sender);
        }
        public static List<int> GetRandomNumbers()
        {
            List<int> randomNumbers = new List<int>();
            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                int number;
                do number = random.Next(1, 10);
                while (randomNumbers.Contains(number));
                randomNumbers.Add(number);
            }
            return randomNumbers;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            int[,] boardInts = new int[9, 9];
            Random random = new Random();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    boardInts[i, j] = SudokuRule(i, j);
                    TxtMatrix[i, j].Text = boardInts[i, j] + "";//ekranda göster
                }
            }

        }
        private int SudokuRule(int i, int j)
        {
            //aynı satırda aynı sayı sadece bir kere yer almalıdır.
            //aynı sütunda aynı sayı sadece bir kere yer almalıdır.
            //aynı 3*3 aynı sayı sadece bir kere yer almalıdır.
            
            return i * j;
        }

        private void ControlToMatrix(TextBox textBox)
        {
            string Tname = textBox.Name;
            int Tx = int.Parse(Tname[1].ToString());//1.index x 
            int Ty = int.Parse(Tname[3].ToString());//2. index y değerini
            string Pname = textBox.Parent.Name;
            int Px = int.Parse(Pname[1].ToString());
            int Py = int.Parse(Pname[3].ToString());
            int X = (Px * 3) + Tx;//Panelde index bir artarsa 3 kabul ediyoruz çünkü içinde textbox sayısı 3 :)
            int Y = (Py * 3) + Ty;
            Goster(X, Y);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        public void Goster(int satirIndex, int SütunIndex)
        {
            MatrixOnLoad();
            for (int i = 0; i <= TxtMatrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= TxtMatrix.GetUpperBound(1); j++)
                {
                    //satir için //sütun için
                    if (i == satirIndex || j == SütunIndex)
                        TxtMatrix[i, j].BackColor = Color.Azure;//hücrenin satırında ki sütunundakiler de bu renkte
                }
            }
            TxtMatrix[satirIndex, SütunIndex].BackColor = SystemColors.GradientActiveCaption; //üzerine gelinen hücre 
        }

        private void MatrixOnLoad()
        {
            for (int i = 0; i <= TxtMatrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= TxtMatrix.GetUpperBound(1); j++)
                {
                    GameHelper(i, State.Row);
                    TextBox[] textBoxs = {t0, t1, t2, t3, t4, t5, t6, t7, t8};
                    TxtMatrix[i, j] = textBoxs[j];
                }
            }
        }

        private void txt_KeyDown(object sender, KeyEventArgs e)// ctrl + v kontrolü
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V)
            {
                TextBox txt = ((TextBox)sender); //hangi textboxa yapıstırılıyorsa onu muhataba alıyor
                char key = Clipboard.GetText()[0]; //bizi  sadece ilk karakteri ilgilendirir.
                bool state = char.IsDigit(key);
                txt.Text = (state == true) ? (key + "") : String.Empty; //panodaki karakter sayi ise al kabul etme .d
            }
        }
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        void GameHelper(int index, State state)
        {
            if (state == State.Row)
            {
                if (index >= 0 && index < 3)
                {
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            cells[i] = pnlSudoku.Controls[$"P0_{i}"] as Panel;
                }
                else if (index >= 3 && index < 6)
                {
                    index = (index % 3);
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            cells[i] = pnlSudoku.Controls[$"P1_{i}"] as Panel;
                }
                else
                {
                    index = (index % 3);
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            cells[i] = pnlSudoku.Controls[$"P2_{i}"] as Panel;
                }
                //TextBox[] textBoxs = new TextBox[9];
                //int TIndex = 0;
                //for (int i = 0; i < 3; i++)
                //{
                //    for (int j = 0; j < 3; j++)
                //    {
                //        textBoxs[TIndex] = cells[i].Controls[$"T{index}_{j}"] as TextBox;
                //        TIndex++;
                //    }
                //}
                t0 = cells[0].Controls[$"T{index}_0"] as TextBox;
                t1 = cells[0].Controls[$"T{index}_1"] as TextBox;
                t2 = cells[0].Controls[$"T{index}_2"] as TextBox;

                t3 = cells[1].Controls[$"T{index}_0"] as TextBox;
                t4 = cells[1].Controls[$"T{index}_1"] as TextBox;
                t5 = cells[1].Controls[$"T{index}_2"] as TextBox;

                t6 = cells[2].Controls[$"T{index}_0"] as TextBox;
                t7 = cells[2].Controls[$"T{index}_1"] as TextBox;
                t8 = cells[2].Controls[$"T{index}_2"] as TextBox;
            }
            if (state == State.Column)
            {
                if (index >= 0 && index < 3)
                {
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            cells[i] = pnlSudoku.Controls[$"P{i}_0"] as Panel;
                }
                else if (index >= 3 && index < 6)
                {
                    index = (index % 3);
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            cells[i] = pnlSudoku.Controls[$"P{i}_1"] as Panel;
                }
                else
                {
                    index = (index % 3);
                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                            cells[i] = pnlSudoku.Controls[$"P{i}_2"] as Panel;
                }
                //TextBox[] textBoxs = new TextBox[9];
                //int TIndex = 0;
                //for (int i = 0; i < 3; i++)
                //{
                //    for (int j = 0; j < 3; j++)
                //    {
                //        textBoxs[TIndex] = cells[i].Controls[$"T{j}_{index}"] as TextBox;
                //        TIndex++;
                //    }
                //}
                t0 = cells[0].Controls[$"T0_{index}"] as TextBox;
                t1 = cells[0].Controls[$"T1_{index}"] as TextBox;
                t2 = cells[0].Controls[$"T2_{index}"] as TextBox;

                t3 = cells[1].Controls[$"T0_{index}"] as TextBox;
                t4 = cells[1].Controls[$"T1_{index}"] as TextBox;
                t5 = cells[1].Controls[$"T2_{index}"] as TextBox;

                t6 = cells[2].Controls[$"T0_{index}"] as TextBox;
                t7 = cells[2].Controls[$"T1_{index}"] as TextBox;
                t8 = cells[2].Controls[$"T2_{index}"] as TextBox;
            }
        }
        void RowHelper(int rowIndex, int[] Numbers)
        {
            for (int i = 0; i <= TxtMatrix.GetUpperBound(0); i++)
            {
                TxtMatrix[rowIndex, i].Text = Numbers[i].ToString();
            }
        }
        void ColumnHelper(int rowIndex, int[] Numbers)
        {
            for (int i = 0; i <= TxtMatrix.GetUpperBound(1); i++)
            {
                TxtMatrix[i, rowIndex].Text = Numbers[i].ToString();
            }
        }
        void RegionHelper(string PanelName, object[,] Numbers)
        {
            Panel myPanel = pnlSudoku.Controls[PanelName] as Panel;
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    myPanel.Controls[$"T{j}_{i}"].Text = Numbers[i, j].ToString();
                }
            }
        }
    }
}
