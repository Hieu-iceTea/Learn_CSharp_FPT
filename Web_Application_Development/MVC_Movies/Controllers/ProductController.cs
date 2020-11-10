using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Movies.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public string Index()
        {
            return "Product page";
        }

        public string Display(int id, string name, string category)
        {
            return HttpUtility.HtmlEncode("id: " + id + ", name: " + name + ", category: " + category);
        }
    }
}