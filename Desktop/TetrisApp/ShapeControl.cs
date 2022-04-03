using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisApp
{
    /// <summary>bu sınıf hareket eden şeklin kontrolünü sağlamak içindir</summary>
    public class ShapeControl
    {
        private TetrisAppForm appForm;
        private Control control;
        private Panel panelCurrentShape;
        private Panel panelGameZone;
        private Block[,] cellsControls;
        private Panel mainblock;
        private Point mainblockLocation;
        private Control.ControlCollection controlCollection;

        ///<summary>
        /// 
        ///</summary>
        /// <param name="control">Control Sınıfından veya bu sınıftan türeyen bir control nesnesi alır</param>
        public ShapeControl(Control control)
        {
            this.control = control;
            appForm = Application.OpenForms["TetrisAppForm"] as TetrisAppForm;
            GameSetting setting = new GameSetting();
            mainblock = control.Controls[setting.BlockName] as Panel;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool isLeft()
        {

            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool isRight()
        {

            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool isDown()
        {

            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool isUp()
        {

            return true;
        }
    }
}
