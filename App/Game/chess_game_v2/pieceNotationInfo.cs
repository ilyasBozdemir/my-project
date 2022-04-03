using chess_game.chessSettings;
using chess_game_v2;
using chess_game_v2.chessPieceTypes;
using chessSettings;

namespace chess_game
{
    public class pieceNotationInfo
    {
        chessForm chessForm;
        char[] satir = chessBoardInfo.satir;
        char[] sutun = chessBoardInfo.sutun;
        public chessPieceType PieceType { get; private set; }
        public chessPiecePoint PiecePoint { get; private set; }
        public NullPiece piece { get; private set; }
        private string PieceNotation;
        /*
         * x: alır
         * * Şah kanadında yapılan rok hamlesi (Kısa rok=Küçük rok) O-O; 
         * Vezir kanadında yapılan rok (Uzun rok=Büyük rok) O-O-O işaretiyle gösterilir.
         * +: şah tehdidi
         * #: şah mat
         * !: iyi hamle 
         * !! : Çok iyi hamle
         * ?: kötü hamle
         * ??: çok kötü hamle
         * 
         * “e.p”= geçerken alma (piyonun özel bir hamlesi)
         * 1-0 = beyaz kazandı
         * 0-1 = siyah kazandı
         * ½ : berabere
        */
        /// <summary>
        /// hamle yapılırken taşın bilgisini alır.
        /// Hamle Yapıldıktan hemen sonra tetiklenir.
        /// </summary>
        /// <param name="pieceInfo">
        ///  Hamle yapan taşı temsil eder.
        /// <returns>
        /// geriye satranç notasyonu bilgisini döndürür.
        /// </returns>
        public string GetPieceNotation(pieceInfo pieceInfo)
        {
            piece = pieceInfo.SelectedPiece;
            bool IsPiecePlaceisFull = false;
            if (IsPiecePlaceisFull)
            {
                PieceNotation = $"{piece.PieceNotationPrefix}x{pieceInfo.SelectedPieceNotation}";//Example: Axf6
            }
            else
            {
                PieceNotation = $"{piece.PieceNotationPrefix}{pieceInfo.SelectedPieceNotation}";//Example: e4
            }
            return PieceNotation;
        }
    }
}
