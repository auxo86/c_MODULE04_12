using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MODULE04_09.DAL;
using MODULE04_09.Models;

namespace MODULE04_09.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        //Get: Home/ProductByID/1
        //Get: Home/ProductByID?ID=1
        public ActionResult ProductByID(int id)
        {
            ProductSystem sys = new ProductSystem();
            var result = sys.GetProductByID(id);

            return View(result);
        }

        public ActionResult ProductsByCategory(int id)
        {
            ProductSystem sys = new ProductSystem();
            var result = sys.GetProductsByCategoryID(id);
            return View(result);
        }
    }
}