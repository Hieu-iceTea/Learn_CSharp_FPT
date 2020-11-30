using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using MyFood.WebSite.Models;
using MyFood.WebSite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFood.WebSite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileService FoodService;
        public IEnumerable<Food> Foods { get; private set;}

        public IndexModel(ILogger<IndexModel> logger, JsonFileService foodService)
        {
            _logger = logger;
            FoodService = foodService;
        }

        public void OnGet()
        {
            Foods = FoodService.GetFoods();
        }
    }
}
