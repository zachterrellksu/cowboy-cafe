/*
    Author: Zachary Terrell

    Class Name: index.cshtml.cs

    Purpose: Backend of landing pagecmin, cmax, 
*/

using System;
using System.Collections.Generic;
using System.Linq;
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

        /// <summary>
        /// The items
        /// </summary>
        public IEnumerable<IOrderItem> Items { get; protected set; } = Menu.CompleteMenu();

        /// <summary>
        /// What the user is searching for 
        /// </summary>
        public string SearchTerms { get; set; }

        /// <summary>
        /// Different catagories of item
        /// </summary>
        public string[] Categories { get; set; }
        
        /// <summary>
        /// Minimum amount of calories
        /// </summary>
        public int? CaloriesMin { get; set; }

        /// <summary>
        /// Maximum amount of calories
        /// </summary>
        public int? CaloriesMax { get; set; }

        /// <summary>
        /// Minimum Price
        /// </summary>
        public double? PriceMin { get; set; }

        /// <summary>
        /// Maximum amount of calories
        /// </summary>
        public double? PriceMax { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet(int? cmin, int? cmax, double? pmin, double? pmax)
        {
            CaloriesMin = cmin;
            CaloriesMax = cmax;
            PriceMin = pmin;
            PriceMax = pmax;
            SearchTerms = Request.Query["SearchTerms"];
            Categories = Request.Query["Categories"];
            Items = Menu.Search(Items, SearchTerms);
            Items = Menu.FilterByCategory(Items, Categories);
            Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
            Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
        }

        //public void OnPost()
        //{
        //    Items = Menu.Search(Items, SearchTerms);
        //    Items = Menu.FilterByCategory(Items, Categories);
        //    Items = Menu.FilterByCalories(Items, CaloriesMin, CaloriesMax);
        //    Items = Menu.FilterByPrice(Items, PriceMin, PriceMax);
        //}
        
    }
}
