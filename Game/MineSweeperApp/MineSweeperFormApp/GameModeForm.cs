namespace MineSweeperFormApp
{
    public partial class GameModeForm : Form
    {
        GameForm gameForm = new GameForm();
        public GameModeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm.mode = GameMode.Basic;
            gameForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm.mode = GameMode.Middle;
            gameForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameForm.mode = GameMode.Hard;
            gameForm.Show();
        }

        private void GameModeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}