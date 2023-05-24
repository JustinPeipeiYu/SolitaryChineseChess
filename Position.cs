namespace ChineseChessAlly.Pages
{
    public class Position : Board
    {
        public int C { get; set; }
        public int R { get; set; }
        public Position(double x, double y, double w, int c, int r)
        {
            X = x; Y=y; W = w; C = c; R=r;
        }
    }
}


