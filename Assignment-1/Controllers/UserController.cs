using Assignment_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_1.Controllers
{
    public class UserController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        // GET: User
        [HttpGet]
        public ActionResult Create()
        {
            ViewData["Name"] = "User Registration";
            ViewBag.Title = "MVC Validation";
            ViewBag.CountryList = db.Countries;
            ViewBag.CityList = db.Cities;
            var model = new User();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(User model)
        {

            if (ModelState.IsValid)
            {
                //TO DO: data processing
                HttpCookie cookie = new HttpCookie("cookie", model.Name);
                Response.Cookies.Add(cookie);

                Session["Name"] = model.Name;
                TempData["Email"] = model.Email;
                TempData["Message"] = "Your Registration has been done successfully!";
                return RedirectToAction("Message");
            }

            //if (ModelState.IsValid)
            //{
            //    // code to save record  and redirect to listing page
            //}
            ViewBag.CountryList = db.Countries;
            ViewBag.CityList = db.Cities;
            return View(model);
        }
        public ActionResult Message()
        {
            HttpCookie cookie = Request.Cookies["cookie"];
            string name = cookie.Value;

            TempData.Keep("Email");
            return View();
        }

        public ActionResult Data(int? Id, string name, string address)
        {
            string n1 = Request.QueryString["Name"];
            string add = Request.QueryString["Address"];

            return View();
        }
        public ActionResult FillCity(int Country)
        {
            var cities = db.Cities.Where(c => c.CountryId == Country);
            return Json(cities, JsonRequestBehavior.AllowGet);
        }
    }
}
