using System.Collections.Generic;

namespace OgielBoardGamesShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<BoardGame> BoardGames { get; set; }
    }
}