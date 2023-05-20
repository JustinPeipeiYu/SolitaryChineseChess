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

        

        public List<Piece> blackPieces = new List<Piece> { blackGeneral, blackGuard1, blackGuard2, blackElephant1, 
            blackElephant2, blackHorse1, blackHorse2, blackRook1, blackRook2, blackCannon1, blackCannon2, 
            blackSoldier1, blackSoldier2, blackSoldier3, blackSoldier4, blackSoldier5};
        public List<Piece> redPieces = new List<Piece> { redGeneral, redGuard1, redGuard2, redElephant1, redElephant2, 
            redHorse1, redHorse2, redRook1, redRook2, redCannon1, redCannon2, redSoldier1, redSoldier2, 
            redSoldier3, redSoldier4, redSoldier5 };
        
        
        public bool checkInside(double x1, double y1, double x2, double y2, int width)
        {
            //takes any two coordinates and checks if the distance between is less than a given value
            double a = x1 - x2;
            double a2 = a * a;
            double b = y1 - y2;
            double b2 = b * b;
            return (Math.Sqrt(a2 + b2) <= width);
        }

        public void OnGet()
        {
            System.Console.WriteLine(blackPieces.Count);
            System.Console.WriteLine(redPieces.Count);
        }
    }
}


