using Microsoft.AspNetCore.Mvc;
using OgielBoardGamesShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgielBoardGamesShop.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IBoardGameRepository _boardGameRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IBoardGameRepository boardGameRepository, ShoppingCart shoppingCart)
        {
            _boardGameRepository = boardGameRepository;
            _shoppingCart = shoppingCart;
        }

        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int boardGameId)
        {
            var selectedBoardGame = _boardGameRepository.AllBoardGames.FirstOrDefault(b => b.BoardGameId == boardGameId);

            if (selectedBoardGame != null)
            {
                _shoppingCart.AddToCart(selectedBoardGame, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int boardGameId)
        {
            var selectedBoardGame = _boardGameRepository.AllBoardGames.FirstOrDefault(b => b.BoardGameId == boardGameId);

            if (selectedBoardGame != null)
            {
                _shoppingCart.RemoveFromCart(selectedBoardGame);
            }
            return RedirectToAction("Index");
        }

    }
}
