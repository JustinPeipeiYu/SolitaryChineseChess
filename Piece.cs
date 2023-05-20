using System.Diagnostics.Metrics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ChineseChessXiangQi.Pages
{
    public class Piece: IPiece
    {
        public char A { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public char C { get; set; }
        public double W { get; set; }
        public bool S { get; set; }
        public Piece(char a, char c, double x, double y, double w, bool s)
        {
            A = a;
            C = c;
            X = x;
            Y = y;
            W = w;
            S = s;
        }
        public Move()
        {

        }
        

    }
}


