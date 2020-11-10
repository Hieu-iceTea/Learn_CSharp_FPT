using System.Web;
using System.Web.Mvc;

namespace MVC_Movies.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        //public ActionResult Index()
        //{
        //    return View();
        //}


        public string Index()
        {
            return "Xin chao";
        }

        public string Welcome(string name, int ID = 1)
        {
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
    }
}