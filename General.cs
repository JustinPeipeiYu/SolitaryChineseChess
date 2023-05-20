
namespace ChineseChessXiangQi.Pages
{
    public class General : Piece
    {
        public char A { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public General(char a, char c, double x, double y)
        {
            Piece  = new Piece(a, c, x, y);
        }
    }
}


