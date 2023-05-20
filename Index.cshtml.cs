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

        public static int width { get; set; } = 60;
        public static int height { get; set; } = 60;

        public static int xStart { get; set; } = 200;

        public static int yStart { get; set; } =50;
        //all 32 game pieces
        public Piece blackGeneral = new Piece(5, xStart + 4 * width, yStart);
        public Piece blackGuard1 = new Piece(4, xStart + 3 * width, yStart);
        public Piece blackGuard2 = new Piece(6, xStart + 5 * width, yStart);
        public Piece blackElephant1 = new Piece(3, xStart + 2 * width, yStart);
        public Piece blackElephant2 = new Piece(7, xStart + 6 * width, yStart);
        public Piece blackHorse1 = new Piece(2, xStart + 1 * width, yStart);
        public Piece blackHorse2 = new Piece(8, xStart + 7 * width, yStart);
        public Piece blackRook1 = new Piece(1, xStart, yStart);
        public Piece blackRook2 = new Piece(9, xStart + 8 * width, yStart);
        public Piece blackCannon1 = new Piece(10,xStart + 1 * width, yStart + 2 * width);
        public Piece blackCannon2 = new Piece(11, xStart + 7 * width, yStart + 2 * width);
        public Piece blackSoldier1 = new Piece(12, xStart, yStart + 3 * width);
        public Piece blackSoldier2 = new Piece(13, xStart+2*width, yStart + 3 * width);
        public Piece blackSoldier3 = new Piece(14, xStart + 4 * width, yStart + 3 * width);
        public Piece blackSoldier4 = new Piece(15, xStart + 6 * width,yStart + 3 * width);
        public Piece blackSoldier5 = new Piece(16, xStart + 8 * width, yStart + 3 * width);
        public Piece redGeneral = new Piece(28, xStart + 4 * width, yStart + 9 * width);
        public Piece redGuard1 = new Piece(27, xStart + 3 * width, yStart + 9 * width);
        public Piece redGuard2 = new Piece(29, xStart + 5 * width, yStart + 9 * width);
        public Piece redElephant1 = new Piece(26, xStart + 2 * width, yStart + 9 * width);
        public Piece redElephant2 = new Piece(30, xStart + 6 * width, yStart + 9 * width);
        public Piece redHorse1 = new Piece(25, xStart + 1 * width, yStart + 9 * width);
        public Piece redHorse2 = new Piece(31, xStart + 7 * width, yStart + 9 * width);
        public Piece redRook1 = new Piece(24, xStart, yStart + 9 * width);
        public Piece redRook2 = new Piece(32, xStart + 8 * width, yStart + 9 * width);
        public Piece redCannon1 = new Piece(22, xStart + 1 * width, yStart + 7 * width);
        public Piece redCannon2 = new Piece(23, xStart + 7 * width, yStart + 7 * width);
        public Piece redSoldier1 = new Piece(17, xStart, yStart + 6 * width);
        public Piece redSoldier2 = new Piece(18, xStart + 2 * width, yStart + 6 * width);
        public Piece redSoldier3 = new Piece(19, xStart + 4 * width, yStart + 6 * width);
        public Piece redSoldier4 = new Piece(20, xStart + 6 * width, yStart + 6 * width);
        public Piece redSoldier5 = new Piece(21, xStart + 8 * width, yStart + 6 * width);

        public void OnGet()
        {

        }
    }
}


