using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TetrisGame.TetrisGame.GameZoneCodeBehind;

namespace TetrisGame.GameZone
{
    public class GamePlay
    {
        private int width;
        private int height;
        private byte RowCount;
        private byte ColumnCount;
        private byte PanelCellSize;

        private Panel splitterPanel(byte PanelCellSize, byte RowCount, byte ColumnCount)
        {
            Panel Cell, MainPanel = new Panel();
            MainPanel.Size = new Size(width, height);
            GamePlayCode playCode = new GamePlayCode();
            byte[,] zoneBytes = playCode.bytes();
            for (int i = 0; i < RowCount; i++)
                for (int j = 0; j < ColumnCount; j++)
                {
                    Cell = new Panel();
                    Cell.Size = new Size((PanelCellSize - 1), (PanelCellSize - 1));
                    Cell.Location = new Point(PanelCellSize * j, i * PanelCellSize);
                    if (zoneBytes[i, j] == 0)
                    {
                        Cell.BackColor = Color.Black;
                    }
                    else
                    {
                        byte value = zoneBytes[i, j];
                        switch (value)
                        {
                            case 0: Cell.BackColor = Color.Black; break;
                            case 1: Cell.BackColor = Color.Red; break;
                            case 2: Cell.BackColor = Color.Purple; break;
                            case 3: Cell.BackColor = Color.DarkBlue; break;
                            case 4: Cell.BackColor = Color.Yellow; break;
                            case 5: Cell.BackColor = Color.Green; break;
                            case 6: Cell.BackColor = Color.LightBlue; break;
                            case 7: Cell.BackColor = Color.YellowGreen; break;
                        }
                    }
                    MainPanel.Controls.Add(Cell);
                }

            return MainPanel;
        }

        public Panel GetPlayzone()
        {
            #region Panel Ozellikleri 
            PanelCellSize = 30;
            RowCount = 16;
            ColumnCount = 10;
            width = ColumnCount * PanelCellSize;
            height = RowCount * PanelCellSize;
            #endregion

            Panel panel = splitterPanel(PanelCellSize, RowCount, ColumnCount);
            return panel;
        }
        public Panel GetNextShape()
        {
            #region Panel Ozellikleri 
            PanelCellSize = 30;
            RowCount = 4;
            ColumnCount = 4;
            width = ColumnCount * PanelCellSize;
            height = RowCount * PanelCellSize;
            #endregion
            Panel panel = splitterPanel(PanelCellSize, RowCount, ColumnCount);
            return panel;
        }
    }
}
