using System.Drawing;

namespace chessSettings
{
    public static class chessBoardInfo
    {
        //tablonun satır sütun adları ve konumları bilgisi
        public static char[] satir = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };
        public static char[] sutun = { '8', '7', '6', '5', '4', '3', '2', '1' };
        public static Point[] pointsX
        {
            get
            {
                return new Point[8]
                {
                new Point((20 + 25),-5),
                new Point((20 + 90),-5),
                new Point((20 + 150),-5),
                new Point((20 + 210),-5),
                new Point((20 + 275),-5),
                new Point((20 + 340),-5),
                new Point((20 + 400),-5),
                new Point((20 + 470),-5)
               };
            }
        }
        public static Point[] pointsY
        {
            get
            {
                return new Point[8]
                {
                new Point(0,(20 + 25)),
                new Point(0,(20 + 90)),
                new Point(0,(20 + 150)),
                new Point(0,(20 + 210)),
                new Point(0,(20 + 275)),
                new Point(0,(20 + 340)),
                new Point(0,(20 + 400)),
                new Point(0,(20 + 470))
               };
            }
        }
        //
    }
}
