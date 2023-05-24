using System.Diagnostics.Metrics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ChineseChessAlly.Pages
{
    public class Piece: Board
    {
        public int C { get; set; }
        public int N { get; set; }

        public static int i { get; set; } = -1;
        public static Piece getPiece(Piece[] p)
        {
            i++;
            return p[i];
        }
    }

}


