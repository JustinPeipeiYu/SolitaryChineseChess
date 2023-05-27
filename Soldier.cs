using System.Runtime.CompilerServices;

namespace SolitaryChineseChess.Pages
{
    public class Soldier : Piece
    {
        public Soldier (double x, double y, double w, int c, int n)
        {
            X = x;
            Y = y;
            W = w;
            C = c;
            N = n;
        }
    }
}
