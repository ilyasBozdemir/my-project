using System.Drawing;
namespace chessSettings
{
    public class chessPieceColor
    {
        public Color ForeColor { get; set; }
        public Color BackColor { get; set; }
        public chessPieceColor(Color ForeColor, Color BackColor)
        {
            this.ForeColor = ForeColor;
            this.BackColor = BackColor;
        }
        public override string ToString()
        {
            return $"ForeColor :{ForeColor} BackColor :{BackColor}";
        }
    }
}
