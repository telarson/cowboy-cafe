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
        
        /// <summary>
        /// Collection of entree items
        /// </summary>
        public IEnumerable<IOrderItem> Entrees { get; set; } = Menu.Entrees();

        /// <summary>
        /// Collection of drink items
        /// </summary>
        public IEnumerable<IOrderItem> Drinks { get; set; } = CowboyCafe.Data.Menu.Drinks();

        /// <summary>
        /// Collection of side items
        /// </summary>
        public IEnumerable<IOrderItem> Sides { get; set; } = CowboyCafe.Data.Menu.Sides();

        /// <summary>
        /// Stores the search terms entered into the search box
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; } = "";

        /// <summary>
        /// List of the possible categories for items
        /// </summary>
        public string[] CategoriesList { get { return new string[] { "Entree", "Side", "Drink" }; } }

        /// <summary>
        /// Stores the selected categories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string[] Categories { get; set; }

        /// <summary>
        /// Stores the minimum calories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int? CaloriesMin { get; set; }

        /// <summary>
        /// Stores the maximum calories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int? CaloriesMax { get; set; }

        /// <summary>
        /// Minimum price
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMin { get; set; }

        /// <summary>
        /// Maximum price
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PriceMax { get; set; }

        public void OnGet(int? CaloriesMin, int? CaloriesMax, double? PriceMin, double? PriceMax)
        {
            this.PriceMax = PriceMax;
            this.PriceMin = PriceMin;
            this.CaloriesMin = CaloriesMin;
            this.CaloriesMax = CaloriesMax;

            //Filter the three types based on SearchTerms
            Entrees = Menu.Search(Entrees, SearchTerms);
            Drinks = Menu.Search(Drinks, SearchTerms);
            Sides = Menu.Search(Sides, SearchTerms);

            //Filter based on selected categories
            Entrees = Menu.FilterByCategory(Entrees, Categories);
            Drinks = Menu.FilterByCategory(Drinks, Categories);
            Sides = Menu.FilterByCategory(Sides, Categories);

            //Filter based on given calorie range
            Entrees = Menu.FilterByCalories(Entrees, this.CaloriesMin, this.CaloriesMax);
            Drinks = Menu.FilterByCalories(Drinks, this.CaloriesMin, this.CaloriesMax);
            Sides = Menu.FilterByCalories(Sides, this.CaloriesMin, this.CaloriesMax);

            //Filter based on given price range
            Entrees = Menu.FilterByPrice(Entrees, this.PriceMin, this.PriceMax);
            Drinks = Menu.FilterByPrice(Drinks, this.PriceMin, this.PriceMax);
            Sides = Menu.FilterByPrice(Sides, this.PriceMin, this.PriceMax);

        }
    }
}
