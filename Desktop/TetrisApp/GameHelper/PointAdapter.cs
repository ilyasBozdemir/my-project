using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisApp.GameHelper
{
    public class PointAdapter
    {
        ///<example>amaç dizideki lokasyon ile matris arasında ilişki kurmak
        /// test için bir consol uygulamasında  aşağıdaki kodu calıstırın.
        /// <code>
        /// namespace Test
        /// {
        ///   public class Program
        ///   {
        ///     static void Main(string[] args)
        ///     {
        ///     PointAdapter adapter = new PointAdapter();
        ///     Point shapeLoc = new Point(60, 150);
        ///     Matris matris = adapter.ConvertToMatris(shapeLoc);
        ///     int x = matris.X, y = matris.Y;
        ///     Console.WriteLine($"dizide ki x konumu :{x} y konumu : {y}");
        ///     //outline: dizide ki x konumu :2 y konumu : 5
        ///    } 
        ///  }
        ///}
        /// </code>
        ///</example>
        public Matris ConvertToMatris(Point location)
        {
            Matris matris = new Matris();
            GameSetting gameSetting = new GameSetting();
            int size = gameSetting.BlockSize.Height;
          //int size = gameSetting.BlockSize.Width;
            if (location == new Point(0, 0))
            {
                matris.X = 0;
                matris.Y = 0;
            }
            else
            {
                matris.X = location.X / size;
                matris.Y = location.Y / size;
            }
            return matris;
        }
    }
    public class Matris
    {
        public int X;
        public int Y;
    }
}
