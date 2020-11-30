using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFood.WebSite.Models;
using MyFood.WebSite.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFood.WebSite.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodsController : ControllerBase
    {
        public JsonFileService FoodService { get; }
        public FoodsController(JsonFileService foodService)
        {
            this.FoodService = foodService;
        }

        [HttpGet]
        public IEnumerable<Food> Get()
        {
            return FoodService.GetFoods();
        }

        [Route("Rate")]
        [HttpGet]
        public ActionResult Get([FromQuery] int FoodId, [FromQuery] int Rating)
        {
            FoodService.AddRating(FoodId, Rating);
            return Ok();
        }
    }
}
