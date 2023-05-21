using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;
//for testing purposes
using System.Collections.Generic;
using System;
namespace ChineseChessXiangQi.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public static double xStart = 200;
        public static double yStart = 50;
        public static double width = 60;

        public General bGeneral = new General(xStart + 4 * width, yStart, width, 1);
        public General rGeneral = new General(xStart + 4 * width, yStart + 9 * width,width, 0);
        public Guard bGuard1 = new Guard(xStart + 3 * width, yStart,width, 1);
        public Guard bGuard2 = new Guard(xStart + 5 * width, yStart,width,1);
        public Guard rGuard1 = new Guard(xStart + 3 * width, yStart + 9 * width, width, 0);
        public Guard rGuard2 = new Guard(xStart + 5 * width, yStart + 9 * width,width,0);
        public Elephant bElephant1 = new Elephant(xStart + 2 * width, yStart, width, 1);
        public Elephant bElephant2 = new Elephant(xStart + 6 * width, yStart, width, 1);
        public Elephant rElephant1 = new Elephant(xStart + 2 * width, yStart + 9 * width,width,0);
        public Elephant rElephant2 = new Elephant(xStart + 6 * width, yStart + 9 * width, width, 0);
        public Knight bKnight1 = new Knight(xStart + 1 * width, yStart,width,1);
        public Knight bKnight2 = new Knight(xStart + 7 * width, yStart, width,1);
        public Knight rKnight1 = new Knight(xStart + 1 * width, yStart + 9 * width,width,0);
        public Knight rKnight2 = new Knight(xStart + 7 * width, yStart + 9 * width,width,0);
        public Chariot bChariot1 = new Chariot(xStart, yStart, width, 1);
        public Chariot bChariot2 = new Chariot(xStart + 8 * width, yStart, width, 1);
        public Chariot rChariot1 = new Chariot(xStart, yStart + 9 * width, width, 0);
        public Chariot rChariot2 = new Chariot(xStart + 8 * width, yStart + 9 * width, width,0);
        public Cannon bCannon1 = new Cannon(xStart + 1 * width, yStart + 2 * width, width, 1);
        public Cannon bCannon2 = new Cannon(xStart + 7 * width, yStart + 2 * width, width, 1);
        public Cannon rCannon1 = new Cannon(xStart + 1 * width, yStart + 7 * width, width, 0);
        public Cannon rCannon2 = new Cannon(xStart + 7 * width, yStart + 7 * width, width, 0);
        public Soldier bSoldier1 = new Soldier(xStart + 0 * width, yStart + 3 * width, width, 1);
        public Soldier bSoldier2 = new Soldier(xStart + 2 * width, yStart + 3 * width, width, 1);
        public Soldier bSoldier3 = new Soldier(xStart + 4 * width, yStart + 3 * width, width, 1);
        public Soldier bSoldier4 = new Soldier(xStart + 6 * width, yStart + 3 * width, width, 1);
        public Soldier bSoldier5 = new Soldier(xStart + 8 * width, yStart + 3 * width, width, 1);
        public Soldier rSoldier1 = new Soldier(xStart + 0 * width, yStart + 6 * width, width, 0);
        public Soldier rSoldier2 = new Soldier(xStart + 2 * width, yStart + 6 * width, width, 0);
        public Soldier rSoldier3 = new Soldier(xStart + 4 * width, yStart + 6 * width, width, 0);
        public Soldier rSoldier4 = new Soldier(xStart + 6 * width, yStart + 6 * width, width, 0);
        public Soldier rSoldier5 = new Soldier(xStart + 8 * width, yStart + 6 * width, width, 0);
        /*
        public List<Piece> blackPieces = new List<Piece> { blackGeneral, blackGuard1, blackGuard2, blackElephant1, 
            blackElephant2, blackHorse1, blackHorse2, blackRook1, blackRook2, blackCannon1, blackCannon2, 
            blackSoldier1, blackSoldier2, blackSoldier3, blackSoldier4, blackSoldier5};
        public List<Piece> redPieces = new List<Piece> { redGeneral, redGuard1, redGuard2, redElephant1, redElephant2, 
            redHorse1, redHorse2, redRook1, redRook2, redCannon1, redCannon2, redSoldier1, redSoldier2, 
            redSoldier3, redSoldier4, redSoldier5 };
        */
        /*
        public bool checkInside(double x1, double y1, double x2, double y2, int width)
        {
            //takes any two coordinates and checks if the distance between is less than a given value
            double a = x1 - x2;
            double a2 = a * a;
            double b = y1 - y2;
            double b2 = b * b;
            return (Math.Sqrt(a2 + b2) <= width);
        }
        */
        public void OnGet()
        {
            
            
        }
    }
}


