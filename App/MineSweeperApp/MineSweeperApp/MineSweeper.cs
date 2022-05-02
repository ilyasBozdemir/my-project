namespace MineSweeperApp
{
    /** 
     * @author ilyas 
    **/
    public enum AppType
    {
        ConsoleApp,
        FormApp
    }

    public class MineSweeper
    {
        private int rowNumber { get; set; }
        private int colNumber { get; set; }
        private int elemanSayisi { get; set; }
        private int mineCount { get; set; }
        private int safeZoneCount { get; set; }

        public MineSweeper(int _rowNumber, int _colNumber)
        {
            rowNumber = _rowNumber;
            colNumber = _colNumber;
            //
            elemanSayisi = rowNumber * colNumber;
            mineCount = (elemanSayisi / 4);
            safeZoneCount = elemanSayisi - mineCount;
            //


            //
        }

        public void Run(AppType appType)
        {

        }
    }
}