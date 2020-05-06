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
        [BindProperty(SupportsGet = true)]
        public IEnumerable<IOrderItem> Items { get; protected set; } = Menu.CompleteMenu();

        /// <summary>
        /// What the user is searching for 
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string SearchTerms { get; set; }

        /// <summary>
        /// Different catagories of item
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string[] Categories { get; set; }

        /// <summary>
        /// Minimum amount of calories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int? CaloriesMin { get; set; }

        /// <summary>
        /// Maximum amount of calories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public int? CaloriesMax { get; set; }

        /// <summary>
        /// Minimum Price
        /// </summary>
        [BindProperty (SupportsGet = true)]
        public double? PriceMin { get; set; }

        /// <summary>
        /// Maximum amount of calories
        /// </summary>
        [BindProperty (SupportsGet = true)]
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

            Items = Menu.CompleteMenu();
            if (SearchTerms != null)
            {
                Items = Items.Where(item => item.ToString() != null && 
                                        item.ToString().Contains(SearchTerms, StringComparison.CurrentCultureIgnoreCase));               
            }

            if (Categories != null && Categories.Length != 0)
            {
                Items = Items.Where(item => item != null && Categories.Contains(item.GetType().BaseType.Name));
            }

            if (CaloriesMin == null && CaloriesMax != null)
            {
                Items = Items.Where(item => item.Calories <= CaloriesMax);
            }
            if (CaloriesMax == null && CaloriesMin != null)
            {
                Items = Items.Where(item => item.Calories >= CaloriesMin);
            }
            if (CaloriesMax != null && CaloriesMin != null)
            {

                Items = Items.Where(item => item.Calories >= CaloriesMin && item.Calories <= CaloriesMax);
            }

            if (PriceMin == null && PriceMax != null)
            {
                Items = Items.Where(item => item.Price <= PriceMax);
            }
            if (PriceMax == null && PriceMin != null)
            {
                Items = Items.Where(item => item.Price >= PriceMin);
            }
            if (PriceMax != null && PriceMin != null)
            {
                Items = Items.Where(item => item.Price >= PriceMin && item.Price <= PriceMax);
            }
        }

        public void OnPost()
        {    
            if (SearchTerms != null)
            {
                Items = Items.Where(item => item.ToString() != null && 
                                        item.ToString().Contains(SearchTerms, StringComparison.CurrentCultureIgnoreCase));
            }

            if (Categories != null && Categories.Length != 0)
            {
                Items = Items.Where(item => item != null && Categories.Contains(item.GetType().BaseType.Name));
            }

            if (CaloriesMin == null && CaloriesMax != null)
            {
                Items = Items.Where(item => item.Calories <= CaloriesMax);
            }
            if (CaloriesMax == null && CaloriesMin != null)
            {
                Items = Items.Where(item => item.Calories >= CaloriesMin);
            }
            if (CaloriesMax != null && CaloriesMin != null)
            {

                Items = Items.Where(item => item.Calories >= CaloriesMin && item.Calories <= CaloriesMax);
            }

            if (PriceMin == null && PriceMax != null)
            {
                Items = Items.Where(item => item.Price <= PriceMax);
            }
            if (PriceMax == null && PriceMin != null)
            {
                Items = Items.Where(item => item.Price >= PriceMin);
            }
            if (PriceMax != null && PriceMin != null)
            {
                Items = Items.Where(item => item.Price >= PriceMin && item.Price <= PriceMax);
            }
        }
    }
}
