using Microsoft.AspNetCore.Mvc;
using OgielBoardGamesShop.Models;
using OgielBoardGamesShop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgielBoardGamesShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBoardGameRepository _boardGameRepository;

        public HomeController(IBoardGameRepository boardGameRepository)
        {
            _boardGameRepository = boardGameRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                BoardGamesOfTheWeek = _boardGameRepository.BoardGamesOfTheWeek
            };

            return View(homeViewModel);
        }
    }
}
