using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisApp
{
    public class ShapeColor
    {
       
        public static Color ShapeSCellColor = Color.Red;
        public static Color ShapeIellColor = Color.Purple;
        public static Color ShapeZCellColor = Color.Blue;
        public static Color ShapeLCellColor = Color.Yellow;
        public static Color ShapeJCellColor = Color.Turquoise;
        public static Color ShapeOCellColor = Color.Green;
        public static Color ShapeTCellColor = Color.Orange;
        public static Color[] colors = new Color[8];
        public ShapeColor()
        {

            //colors[0] = Color.Empty;
            colors[1] = ShapeSCellColor;
            colors[2] = ShapeIellColor;
            colors[3] = ShapeZCellColor;
            colors[4] = ShapeLCellColor;
            colors[5] = ShapeJCellColor;
            colors[6] = ShapeOCellColor;
            colors[7] = ShapeTCellColor;
        }
        public  Color GetShapeColor(int Number)
        {
            return (colors.Length > Number)
                ? colors[Number]
                : throw new Exception("Girilen sayı sistemimizde ki hiçbir renge karşılık gelmiyor");
        }
        public  byte GetColorNumber(Color color)
        {
            if (Array.IndexOf(colors, color) == -1 || Array.IndexOf(colors, color) == 0)
                throw new ArgumentOutOfRangeException(color.Name,
                    "Girilen renk sistemimizde ki hiçbir sayıyı karşılık gelmiyor");
            else
                return byte.Parse(Array.IndexOf(colors, color).ToString());
        }
    }
}
