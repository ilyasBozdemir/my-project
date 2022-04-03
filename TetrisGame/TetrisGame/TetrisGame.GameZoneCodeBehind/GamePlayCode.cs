using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TetrisGame.GameZone;

namespace TetrisGame.TetrisGame.GameZoneCodeBehind
{
    public class GamePlayCode
    {
        public byte _x { get; set; }
        public byte _y { get; set; }
        public byte _value { get; set; }

        public GamePlayCode()
        {

        }
        public GamePlayCode(byte x, byte y, byte _value)
        {
            this._x = x;
            this._y = y;
            this._value = _value;
        }
        public byte[,] bytes()
        {
            byte[,] zoneBytes =
            {
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
            };
            return zoneBytes;
        }

        public void AddShape()
        {
            byte[,] zone = bytes();
            if (_x <= zone.GetUpperBound(0) && _y <= zone.GetUpperBound(1))
            {
                zone[_x, _y] = _value;
            }
            else
            {
                MessageBox.Show("Dizin değerleri dizinin sınırları dısındaydı");
            }

        }
    }
}