using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisGame.TetrisShape
{
    public partial class Shape : UserControl
    {
        public Shape()
        {
            InitializeComponent();
        }
        private string myVar;
        public string SekilAdı
        {
            get { return myVar; }
            set
            {
                myVar = value;
                hallet(value);
            }
        }
        void hallet(string deger)
        {

            Panel[] panels = { };
            if (deger != null)
            {
                if (myVar.ToUpper() == "Z")
                {
                    Array.Clear(panels, 0, panels.Length);
                    panels = new Panel[] { PnlCell03, PnlCell06, PnlCell07, PnlCell10 };
                }

                else if (myVar.ToUpper() == "I")
                {
                    Array.Clear(panels, 0, panels.Length);
                    panels = new Panel[] { PnlCell03, PnlCell07, PnlCell11, PnlCell15 };
                }
                else if (myVar.ToUpper() == "T")
                {
                    Array.Clear(panels, 0, panels.Length);

                    panels = new Panel[] { PnlCell11, PnlCell14, PnlCell15, PnlCell16 };
                }
                //
                for (int i = 0; i < panels.Length; i++)
                {
                    panels[i].BackColor = Color.Red;
                }
            }
            if (deger == null)
            {
                panels = new Panel[]
                {
                    PnlCell01, PnlCell02, PnlCell03, PnlCell04 , PnlCell05 , PnlCell06 , PnlCell07 , PnlCell08,
                    PnlCell09, PnlCell10, PnlCell11, PnlCell12 , PnlCell13 , PnlCell14 , PnlCell15 , PnlCell16
                };
                for (int i = 0; i < panels.Length; i++)
                {
                    panels[i].BackColor = Color.DodgerBlue;
                }
            }

        }
    }
}
