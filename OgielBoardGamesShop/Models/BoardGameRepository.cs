using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgielBoardGamesShop.Models
{
    public class BoardGameRepository : IBoardGameRepository
    {
        private readonly AppDbContext _appDbContext;

        public BoardGameRepository(AppDbContext appDbCopntext)
        {
            _appDbContext = appDbCopntext;
        }

        public IEnumerable<BoardGame> AllBoardGames
        {
            get
            {
                return _appDbContext.BoardGames.Include(c => c.Category);
            }
        }

        public IEnumerable<BoardGame> BoardGamesOfTheWeek
        {
            get
            {
                return _appDbContext.BoardGames.Include(c => c.Category).Where(b => b.IsGameOfTheWeek);
            }
        }

        public BoardGame GetBoardGameById(int boardGameId)
        {
            return _appDbContext.BoardGames.FirstOrDefault(b => b.BoardGameId == boardGameId);
        }
    }
}
