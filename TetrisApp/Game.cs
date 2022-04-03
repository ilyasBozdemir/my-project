using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using TetrisApp.GameHelper;
using Timer = System.Windows.Forms.Timer;

namespace TetrisApp
{
    public partial class Game
    {
        private Timer gameTimer;
        private ShapeControl control;
        private GameSetting setting;
        private ByteToBlock byteToBlock;
        private BlockToByte blockToByte;
        private ShapeRotation rotation;
        private TetrisAppForm appForm;
        private Panel panelGameZone;
        private Panel panelNextShape;
        private Panel panelCurrentShape;
        private GamePlayzone playzone;
        private byte[,] TempPlayZoneBytes;
        private int level = 1;
        private void InitializeComponent()
        {
            //setting
            setting= new GameSetting();
            //appForm
            appForm = (TetrisAppForm)Application.OpenForms[setting.TetrisAppFormName];
            //panelGameZone
            panelGameZone = (Panel) appForm.Controls[setting.PnlGameZoneName];
            //panelNextShape
            panelNextShape = (Panel) appForm.Controls[setting.PnlNextShapeName];
            //panelGameZone.panelCurrentShape
            panelCurrentShape = (Panel) panelGameZone.Controls[setting.PnlCurrentShapeName];
            //control
            control = new ShapeControl(panelCurrentShape);
            //gameTimer
            gameTimer = new Timer();
            gameTimer.Interval = setting.LevelSpeed(level);
            gameTimer.Enabled = true;
            gameTimer.Tick += new EventHandler(gameTimer_Tick);
            //rotation
            rotation= new ShapeRotation();
            //byteToBlock
            byteToBlock = new ByteToBlock();
            //blockToByte
            blockToByte = new BlockToByte();
            //playzone
            playzone = new GamePlayzone();
        }
    }
    public partial class Game
    {
        public Game()
        {
            InitializeComponent();
            TempPlayZoneBytes = playzone.GetPlayZoneBytes();
        }
        public void StartGame()
        {
            NewGame();
            gameTimer.Start();
        }
        /// <summary>
        /// Yeni oyun baslatır.
        /// </summary>
        private void NewGame()
        {
            panelGameZone.BackColor = setting.TetrisBackgroudColor;
            panelCurrentShape.BackColor = setting.TetrisBackgroudColor;
            panelCurrentShape.Controls.Add(Shape.GetRandomShape());
            panelGameZone.Controls.Add(playzone.GetPlayZone(TempPlayZoneBytes));
        }
        /// <summary>16*10  matris'e şekli eklerken sahneye gerekli koordinatları alır adapte eder
        ///<paramref name="shapeLoc"/> dizisi ile şekillerin lokasyonunu alır
        /// <paramref name="value"/> ile o lokasyona değeri atar
        /// </summary>
        public void AddShape(Point[] shapeLoc, byte value)
        {
            PointAdapter adapter = new PointAdapter();
            for (int i = 0; i < shapeLoc.Length; i++)
            {
                Matris matris = adapter.ConvertToMatris(shapeLoc[i]);
                int x = matris.X, y = matris.Y;
                TempPlayZoneBytes[x, y] = value;
            }
        }
        /// <summary>
        /// sekli alır ve matrixe dönüştürür. matrixte 90 derece döndürüp geri şekil olustur.
        /// </summary>
        public void ShapeRotate()
        {
            ControlToMatris controls = new ControlToMatris();

            Block[,] cellsControls = controls.ConvertMatris(panelCurrentShape);//tek boyutu iki boyuta çevir.

            byte[,] blockBytes = blockToByte.GetBytes(cellsControls);

            byte[,] NewblockBytes = rotation._90DegRotateMatrix(blockBytes);

            Block[,] blocks = byteToBlock.GetBlock(NewblockBytes);

            Block mainControl = Shape.CreateShape(blocks);

            panelCurrentShape.Controls.Remove(panelCurrentShape.Controls[setting.BlockName]);//oncekini at
            panelCurrentShape.Controls.Add(mainControl);//yenisini ekle
        }
        /// <summary>
        /// her tik olusunda method tetiklenir. tik süresi interval özelliği ile belirlenir
        /// </summary>
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (control.isDown())
                panelCurrentShape.Top += 30;
        }
        /// <summary>
        /// oyunu duraklatmak için
        /// </summary>
        public void PauseGame()
        {
            gameTimer.Enabled = false;
        }
        /// <summary>
        /// oyuna devam etmek için
        /// </summary>
        public void ContinueGame()
        {
            gameTimer.Enabled = true;
        }
        /// <summary>
        /// oyunun bittiği anlamına gelir
        /// </summary>
        public void EndGame()
        {
            gameTimer.Stop();
        }
    }
}