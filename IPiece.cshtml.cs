using System;

namespace ChineseChessXiangQi.Pages;

public interface IPiece
{
    protected string Name { get; set; }
    protected static double Radius { get; set; }
    protected double X { get; set; }
    protected double Y { get; set; }
    protected bool Display { get; set; }

}



