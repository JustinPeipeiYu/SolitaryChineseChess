using System;

namespace ChineseChessXiangQi.Pages
{
    public class Piece : IPiece
    {
        public string Name { get; set; }
        public double Radius { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public bool Display { get; set; }
        public Piece(string name, double x, double y)
        {
            Name = name;
            Radius = 10;
            X = x;
            Y = y;
            Display = true;
        }
        
    }
}


