using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;
using WebApplication2.ViewModels;


namespace WebApplication2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Random()
        {
            var product = new Product() { Name = "Icecream" };
            var customers = new List<Customer>
            {
               new Customer { Name = "test 1"},
               new Customer { Name = "test 2"}
            };

            var viewModel = new RandomProductViewModel
            {
                Product = product,
                Customer = customers
            };


            ViewData["Product"] = product;

            return View(viewModel);
        }

        public ActionResult Edit(int id) {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        [Route("products/posted/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByPostedYear(int year, int month) {
            return Content(year+"/"+month);
        }
    }
    

}