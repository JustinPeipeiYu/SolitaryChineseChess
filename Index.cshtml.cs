using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Html;
using Microsoft.VisualBasic;

namespace ChineseChessAlly.Pages
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
        public List<Position> positions = new List<Position>();
        public List<Piece> pieces = new List<Piece>();      

        public void OnGet()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 9; j++)
                {//collect all positions by creating specific positions and adding to a list
                    positions.Add(new Position(xStart + (j - 1) * width, yStart + (i - 1) * width, width, i, j));
                }
            }
            //collect all pieces by creating specific pieces and adding to a List
            pieces.Add(new General(xStart + 4 * width, yStart, width, 1, 1));
            pieces.Add(new General(xStart + 4 * width, yStart + 9 * width, width, 0, 1));
            pieces.Add(new Guard(xStart + 3 * width, yStart, width, 1, 6));
            pieces.Add(new Guard(xStart + 5 * width, yStart, width, 1, 6));
            pieces.Add(new Guard(xStart + 3 * width, yStart + 9 * width, width, 0, 6));
            pieces.Add(new Guard(xStart + 5 * width, yStart + 9 * width, width, 0, 6));
            pieces.Add(new Elephant(xStart + 2 * width, yStart, width, 1, 5));
            pieces.Add(new Elephant(xStart + 6 * width, yStart, width, 1, 5));
            pieces.Add(new Elephant(xStart + 2 * width, yStart + 9 * width, width, 0, 5));
            pieces.Add(new Elephant(xStart + 6 * width, yStart + 9 * width, width, 0, 5));
            pieces.Add(new Knight(xStart + 1 * width, yStart, width, 1, 4));
            pieces.Add(new Knight(xStart + 7 * width, yStart, width, 1, 4));
            pieces.Add(new Knight(xStart + 1 * width, yStart + 9 * width, width, 0, 4));
            pieces.Add(new Knight(xStart + 7 * width, yStart + 9 * width, width, 0, 4));
            pieces.Add(new Chariot(xStart, yStart, width, 1, 2));
            pieces.Add(new Chariot(xStart + 8 * width, yStart, width, 1, 2));
            pieces.Add(new Chariot(xStart, yStart + 9 * width, width, 0, 2));
            pieces.Add(new Chariot(xStart + 8 * width, yStart + 9 * width, width, 0, 2));
            pieces.Add(new Cannon(xStart + 1 * width, yStart + 2 * width, width, 1, 3));
            pieces.Add(new Cannon(xStart + 7 * width, yStart + 2 * width, width, 1, 3));
            pieces.Add(new Cannon(xStart + 1 * width, yStart + 7 * width, width, 0, 3));
            pieces.Add(new Cannon(xStart + 7 * width, yStart + 7 * width, width, 0, 3));
            pieces.Add(new Soldier(xStart + 0 * width, yStart + 3 * width, width, 1, 7));
            pieces.Add(new Soldier(xStart + 2 * width, yStart + 3 * width, width, 1, 7));
            pieces.Add(new Soldier(xStart + 4 * width, yStart + 3 * width, width, 1, 7));
            pieces.Add(new Soldier(xStart + 6 * width, yStart + 3 * width, width, 1, 7));
            pieces.Add(new Soldier(xStart + 8 * width, yStart + 3 * width, width, 1, 7));
            pieces.Add(new Soldier(xStart + 0 * width, yStart + 6 * width, width, 0, 7));
            pieces.Add(new Soldier(xStart + 2 * width, yStart + 6 * width, width, 0, 7));
            pieces.Add(new Soldier(xStart + 4 * width, yStart + 6 * width, width, 0, 7));
            pieces.Add(new Soldier(xStart + 6 * width, yStart + 6 * width, width, 0, 7));
            pieces.Add(new Soldier(xStart + 8 * width, yStart + 6 * width, width, 0, 7));
        }
    }
}


