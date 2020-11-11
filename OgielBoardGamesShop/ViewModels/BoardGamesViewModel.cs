using OgielBoardGamesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgielBoardGamesShop.ViewModels
{
    public class BoardGamesViewModel
    {
        public IEnumerable<BoardGame> BoardGames { get; set; }
        public string CurrentCategory { get; set; }
    }
}
