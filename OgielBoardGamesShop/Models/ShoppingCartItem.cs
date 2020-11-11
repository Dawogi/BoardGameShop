using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgielBoardGamesShop.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public BoardGame BoardGame { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }

    }
}
