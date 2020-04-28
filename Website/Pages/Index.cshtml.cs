using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using CowboyCafe.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public IEnumerable<IOrderItem> Entrees { get; set; } = Menu.Entrees();
        public IEnumerable<IOrderItem> Drinks { get; set; } = CowboyCafe.Data.Menu.Drinks();
        public IEnumerable<IOrderItem> Sides { get; set; } = CowboyCafe.Data.Menu.Sides();

        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; } = "";

        public string[] CategoriesList { get { return new string[] { "Entree", "Side", "Drink" }; } }

        [BindProperty(SupportsGet = true)]
        public string[] Categories { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? CaloriesMin { get; set; }

        [BindProperty(SupportsGet = true)]
        public int? CaloriesMax { get; set; }

        [BindProperty(SupportsGet = true)]
        public double? PriceMin { get; set; }

        [BindProperty(SupportsGet = true)]
        public double? PriceMax { get; set; }

        public void OnGet(int? CaloriesMin, int? CaloriesMax, double? PriceMin, double? PriceMax)
        {
            this.PriceMax = PriceMax;
            this.PriceMin = PriceMin;
            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;

            Entrees = Menu.Search(Entrees, SearchTerms);
            Drinks = Menu.Search(Drinks, SearchTerms);
            Sides = Menu.Search(Sides, SearchTerms);

            Entrees = Menu.FilterByCategory(Entrees, Categories);
            Drinks = Menu.FilterByCategory(Drinks, Categories);
            Sides = Menu.FilterByCategory(Sides, Categories);

            Entrees = Menu.FilterByCalories(Entrees, this.CaloriesMin, this.CaloriesMax);
            Drinks = Menu.FilterByCalories(Drinks, this.CaloriesMin, this.CaloriesMax);
            Sides = Menu.FilterByCalories(Sides, this.CaloriesMin, this.CaloriesMax);

            Entrees = Menu.FilterByPrice(Entrees, this.PriceMin, this.PriceMax);
            Drinks = Menu.FilterByPrice(Drinks, this.PriceMin, this.PriceMax);
            Sides = Menu.FilterByPrice(Sides, this.PriceMin, this.PriceMax);


        }
    }
}
