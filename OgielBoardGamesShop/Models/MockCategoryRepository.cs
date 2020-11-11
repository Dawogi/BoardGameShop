using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OgielBoardGamesShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category{CategoryId=1, CategoryName="Abstract", Description="Abstract"},
            new Category{CategoryId=2, CategoryName="Area Control", Description="Area Control"},
            new Category{CategoryId=3, CategoryName="Eurogames", Description="Eurogames"}
        };
    }
}
