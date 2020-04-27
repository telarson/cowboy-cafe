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

        public readonly string[] CategoriesList = { "Entree", "Side", "Drink" };

        [BindProperty(SupportsGet = true)]
        public string[] Categories { get; set; }

        [BindProperty(SupportsGet = true)]
        public uint? CaloriesMin { get; set; }

        [BindProperty(SupportsGet = true)]
        public uint? CaloriesMax { get; set; }

        [BindProperty(SupportsGet = true)]
        public double? PriceMin { get; set; }

        [BindProperty(SupportsGet = true)]
        public double? PriceMax { get; set; }

        public void OnGet()
        {
            Entrees = Menu.Search(Entrees, SearchTerms);
            Drinks = Menu.Search(Drinks, SearchTerms);
            Sides = Menu.Search(Sides, SearchTerms);
        }
    }
}
