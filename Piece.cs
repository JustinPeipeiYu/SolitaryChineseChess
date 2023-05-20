namespace ChineseChessXiangQi.Pages
{
    public class Piece: IPiece
    {
        public int ID { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public Piece(int id, double x, double y)
        {
            ID = id;
            X = x;
            Y = y;
        }
    }
}


