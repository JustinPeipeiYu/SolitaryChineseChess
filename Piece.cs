namespace ChineseChessXiangQi.Pages
{
    public class Piece: IPiece
    {
        public string Name { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public string Color { get; set; }

        public Piece(string name, string color, double x, double y)
        {
            Color = color;
            Name = name;
            X = x;
            Y = y;
        }
    }
}


