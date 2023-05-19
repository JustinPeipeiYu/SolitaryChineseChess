using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;

namespace ChineseChessXiangQi.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public static int width { get; set; } = 50;
        public static int height { get; set; } = 45;

        public static int xStart { get; set; } = 300;

        public static int yStart { get; set; } = 100;
        //all 32 game pieces
        public Piece blackGeneral = new Piece("general", "black", xStart + 4 * width, yStart);
        public Piece blackGuard1 = new Piece("guard", "black", xStart + 3 * width, yStart + 9 * height);
        public Piece blackGuard2 = new Piece("guard", "black", xStart + 5 * width, yStart);
        public Piece blackElephant1 = new Piece("elephant", "black", xStart + 2 * width, yStart);
        public Piece blackElephant2 = new Piece("elephant", "black", xStart + 6 * width, yStart);
        public Piece blackHorse1 = new Piece("horse", "black", xStart + 1 * width, yStart);
        public Piece blackHorse2 = new Piece("horse", "black", xStart + 7 * width, yStart);
        public Piece blackRook1 = new Piece("rook", "black", xStart, yStart);
        public Piece blackRook2 = new Piece("rook", "black", xStart + 8 * width, yStart);
        public Piece blackCannon1 = new Piece("cannon","black",xStart + 1 * width, yStart + 2 * height);
        public Piece blackCannon2 = new Piece("cannon", "black", xStart + 7 * width, yStart + 2 * height);
        public Piece blackSoldier1 = new Piece("soldier", "black", xStart, yStart + 3 * height);
        public Piece blackSoldier2 = new Piece("soldier", "black", xStart+2*width, yStart + 3 * height);
        public Piece blackSoldier3 = new Piece("soldier", "black", xStart + 4 * width, yStart + 3 * height);
        public Piece blackSoldier4 = new Piece("soldier","black", xStart + 6 * width,yStart + 3 * height);
        public Piece blackSoldier5 = new Piece("soldier", "black", xStart + 8 * width, yStart + 3 * height);
        public Piece redGeneral = new Piece("general", "red", xStart + 4 * width, yStart + 9 * height);
        public Piece redGuard1 = new Piece("guard", "red", xStart + 3 * width, yStart + 9 * height);
        public Piece redGuard2 = new Piece("guard", "red", xStart + 5 * width, yStart + 9 * height);
        public Piece redElephant1 = new Piece("elephant", "red", xStart + 2 * width, yStart + 9 * height);
        public Piece redElephant2 = new Piece("elephant", "red", xStart + 6 * width, yStart + 9 * height);
        public Piece redHorse1 = new Piece("horse", "red", xStart + 1 * width, yStart + 9 * height);
        public Piece redHorse2 = new Piece("horse", "red", xStart + 7 * width, yStart + 9 * height);
        public Piece redRook1 = new Piece("rook", "red", xStart, yStart + 9 * height);
        public Piece redRook2 = new Piece("rook", "red", xStart + 8 * width, yStart + 9 * height);
        public Piece redCannon1 = new Piece("cannon", "red", xStart + 1 * width, yStart + 7 * height);
        public Piece redCannon2 = new Piece("cannon", "red", xStart + 7 * width, yStart + 7 * height);
        public Piece redSoldier1 = new Piece("soldier", "red", xStart, yStart + 6 * height);
        public Piece redSoldier2 = new Piece("soldier", "red", xStart + 2 * width, yStart + 6 * height);
        public Piece redSoldier3 = new Piece("soldier", "red", xStart + 4 * width, yStart + 6 * height);
        public Piece redSoldier4 = new Piece("soldier", "red", xStart + 6 * width, yStart + 6 * height);
        public Piece redSoldier5 = new Piece("soldier", "red", xStart + 8 * width, yStart + 6 * height);

        public void OnGet()
        {

        }
    }
}


