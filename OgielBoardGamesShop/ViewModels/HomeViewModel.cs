using OgielBoardGamesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgielBoardGamesShop.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<BoardGame> BoardGamesOfTheWeek { get; set; }
    }
}
