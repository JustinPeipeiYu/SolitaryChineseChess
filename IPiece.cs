namespace ChineseChessXiangQi.Pages
{
    public interface IPiece
    {
        double X { get; }
        double Y { get; }
        char A { get; }
        char C { get; }
        double W { get; }
        bool S { get; }

        Tuple<double, double> Move(double x, double y);

    }
}


