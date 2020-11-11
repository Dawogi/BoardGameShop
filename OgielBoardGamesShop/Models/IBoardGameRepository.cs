using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgielBoardGamesShop.Models
{
    public interface IBoardGameRepository
    {
        IEnumerable<BoardGame> AllBoardGames { get;}
        IEnumerable<BoardGame> BoardGamesOfTheWeek { get; }
        BoardGame GetBoardGameById(int boardGameId);
    }
}
