namespace Dama
{
    public class CellMargin
    {
        public double Top { get; set; }
        public double Left { get; set; }
        public double Right { get; set; }
        public double Bottom { get; set; }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DamaTahtasi();
            //amaç burda çokça buton tarafýndan tek bir olaya yönlendirme
        }
        Button[,] button = new Button[8, 8];
        public void DamaTahtasi()
        {
            CellMargin cellMargin = new CellMargin { Top = 25, Left = 25 };
            Size size = new Size(50, 50);
            for (int i = 0; i <= button.GetUpperBound(0); i++)//[{0},{1}]
            {
                for (int j = 0; j <= button.GetUpperBound(1); j++)//[{0},{1}]
                {
                    
                    button[i, j] = new Button();
                    Button btn = button[i, j];

                    btn.Name = $"{i}.Satýr & {j}.Sütun";
                    btn.Text = $"[{i},{j}]";
                    btn.Click += new EventHandler(buttons_Click);
                    btn.Size = size;
                    btn.Left = (int)cellMargin.Left;
                    btn.Top = (int)cellMargin.Top;

                    Color Color = ColorTranslator.FromHtml("#F4EB42"),
                          Color2 = ColorTranslator.FromHtml("#FD5D5D");
                    if ((i + j) % 2 == 0)// (i + j % 2 == 1)
                    {
                        btn.BackColor = Color;
                        btn.ForeColor = Color2;
                    }
                    else
                    {
                        btn.BackColor = Color2;
                        btn.ForeColor = Color;
                    }
                    cellMargin.Left += 50;
                    groupBox1.Controls.Add(btn);
                }
                cellMargin.Left = 25;
                cellMargin.Top += 50;
            }
        }
        private void buttons_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            MessageBox.Show(btn.Name);
            //MessageBox.Show(((Button)sender).Name);
        }
    }
}