using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TetrisApp.GameHelper;

namespace TetrisApp
{
    public class GamePlayzone
    {
        ///<summary>
        /// bu <param name="playzoneBytes"></param>
        /// parametresi oyun alanını temsil eden 16*10 matrix alır.
        /// geri dönüş olarak matrisin satır sütun  değerine göre panel hücrelerinin rengini ayarlar
        /// </summary>
        private ByteToBlock byteToBlock;
        private GameSetting setting;
        private TetrisAppForm appForm;
        public GamePlayzone()
        {
            //setting
            setting = new GameSetting();
            //appForm
            appForm = (TetrisAppForm)Application.OpenForms[setting.TetrisAppFormName];
        }
        public Block GetPlayZone(byte[,] playzoneBytes)
        {
            byteToBlock = new ByteToBlock();
            Block[,] playzoneBlocks = byteToBlock.GetBlock(playzoneBytes);
            Block mainBlock = new Block();
            mainBlock.Name = setting.BlockName;
            Panel pnlGameZone = appForm.Controls[setting.PnlGameZoneName] as Panel;
            mainBlock.Size = pnlGameZone.Size;
            return Shape.ShapeHelper(mainBlock, playzoneBlocks);
        }
        /// <summary>
        /// sahneyi temsilen boş bir 16*10 matris oluşturur
        /// </summary>
        /// geriye 16*10 olarak satır ve sütunlara 0 atar
        /// <returns></returns>
        public byte[,] GetPlayZoneBytes()
        {
            byte[,] playzoneBytes = new byte[16, 10];
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    playzoneBytes[i, j] = 0;
                }
            }
            return playzoneBytes;
        }
        
     }
}
