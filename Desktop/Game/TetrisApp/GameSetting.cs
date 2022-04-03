using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisApp
{
    public class GameSetting
    {
        /// her bir hücrenin boyutu içindir
        public Size BlockSize;
        /// hücrelerin referanslarını tutan controlün adıdır.(hücreler bu konrolün altında yer almaktadır).
        public string BlockName;
        /// form içerisinde ki oyun alanını temsil eden sekli gosteren panelin adını alır. 
        public string PnlGameZoneName;
        /// formun classNamesini alan field'dir.
        public string TetrisAppFormName;
        /// form içerisinde ki mevcut sekli gosteren panelin adını alır. 
        public string PnlCurrentShapeName;
        /// form içerisinde ki sıradaki sekli gosteren panelin adını alır.
        public string PnlNextShapeName;

        public Color TetrisBackgroudColor;
        /// <summary>
        /// oyun içi tekrar eden ve duruma göre değişen ayarları almak içindir
        /// </summary>
        /// duruma göre değişen derken herhangi bir kontrolün adı değişince sadece burdan değiştirmek proje bütünlüğünü koruyacaktır.
        public GameSetting()
        {
            BlockSize = new Size(30, 30);
            BlockName = "mainBlock";
            PnlNextShapeName = "pnlNextShape";
            TetrisAppFormName = "TetrisAppForm";
            PnlCurrentShapeName = "pnlCurrentShape";
            PnlGameZoneName = "pnlGameZone";
            TetrisBackgroudColor = Color.Black;
        }
        /// <remarks>
        /// parametre olarak <paramref name="level"/> sayısını temsilen alır ve oyun hızını ona göre ayarlar.
        /// bu özellik timer sınıfın interval özelliğini ayarlamak içindir.
        /// </remarks>
        public int LevelSpeed(int level)
        {
            int result = 500 + (50 * level);
            return result;
        }
    }
}
