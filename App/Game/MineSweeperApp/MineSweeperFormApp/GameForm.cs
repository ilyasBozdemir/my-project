using MineSweeperApp;


namespace MineSweeperFormApp
{
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            MineSweeper mine = new MineSweeper(new Matrix(4, 4));
            mine.RunFormApp();
        }
    }
}