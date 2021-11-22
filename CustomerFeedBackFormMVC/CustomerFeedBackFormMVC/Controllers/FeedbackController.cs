using CustomerFeedBackFormMVC.Data;
using CustomerFeedBackFormMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace CustomerFeedBackFormMVC.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly CustomerSatisfactoryFeedBackFormContext _db;

        public FeedbackController(CustomerSatisfactoryFeedBackFormContext db)
        {
            this._db = db;
        }
        // POST: Feedback/Create
        public IActionResult Create()
        {
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

        //GET: Feedback/GetFeedbackInfo 
        public IActionResult GetFeedbackInfo()
        {
            CustomerFeedbackFormViewModel customerFeedbackFormViewModel = new();

            HttpClient client = new();

            var result = client.GetAsync("https://localhost:44393/api/Feedback").Result;

            if (result.IsSuccessStatusCode)
            {
                customerFeedbackFormViewModel = result.Content.ReadAsAsync<CustomerFeedbackFormViewModel>().Result;
            }
            return View(customerFeedbackFormViewModel);
            //return View();
        }

        //FileUpload
        //[HttpPost]
        //public ActionResult UploadFile(HttpPostedFileBase file)
        //{
        //    try
        //    {
        //        if (file.ContentLength > 0)
        //        {
        //            string _FileName = Path.GetFileName(file.FileName);
        //            string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);
        //            file.SaveAs(_path);
        //        }
        //        ViewBag.Message = "File Uploaded Successfully!!";
        //        return View();
        //    }
        //    catch
        //    {
        //        ViewBag.Message = "File upload failed!!";
        //        return View();
        //    }
        //}
    }
}
