using CustomerFeedBackFormMVC.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerFeedBackFormMVC.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly CustomerSatisfactoryFeedBackFormContext _db;

        public FeedbackController(CustomerSatisfactoryFeedBackFormContext db)
        {
            this._db = db;
        }
        // GET: Feedback/Create
        public IActionResult Create()
        {
            //ViewBag.brands = _assetBL.listOfBrands();
            //ViewBag.brands = _assetBL.listOfBrands();
            IEnumerable<SelectListItem> listOfProducts = _db.Products.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString()

            });

            IEnumerable<SelectListItem> listOfCategory = _db.Categories.Select(x => new SelectListItem
            {
                Text = x.Name,
                Value = x.Id.ToString()

            });


            ViewBag.products = listOfProducts;
            ViewBag.category = listOfCategory;


            return View();
        }
    }
}
