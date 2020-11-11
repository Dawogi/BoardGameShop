using Microsoft.AspNetCore.Mvc;
using OgielBoardGamesShop.Models;
using OgielBoardGamesShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgielBoardGamesShop.Controllers
{
    public class BoardGameController : Controller
    {
        private readonly IBoardGameRepository _boardGameRepository;
        private readonly ICategoryRepository _categoryRepository;

        public BoardGameController(IBoardGameRepository boardGameRepository, ICategoryRepository categoryRepository)
        {
            _boardGameRepository = boardGameRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<BoardGame> boardGames;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                boardGames = _boardGameRepository.AllBoardGames.OrderBy(b => b.BoardGameId);
                currentCategory = "All pies";
            }
            else
            {
                boardGames = _boardGameRepository.AllBoardGames.Where(b => b.Category.CategoryName == category)
                    .OrderBy(b => b.BoardGameId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new BoardGamesViewModel
            {
                BoardGames = boardGames,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var boardGame = _boardGameRepository.GetBoardGameById(id);
            if(boardGame == null)
            {
                return NotFound();
            }
            return View(boardGame);
        }
    }
}
