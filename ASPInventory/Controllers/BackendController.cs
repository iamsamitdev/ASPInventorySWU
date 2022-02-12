using ASPInventory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPInventory.Controllers
{
    [SessionCheck]
    public class BackendController : Controller
    {
        // GET: Backend
        public ActionResult Dashboard()
        {
            return View();
        }

        public ActionResult Product()
        {
            ASPInventorySWUDBEnt context = new ASPInventorySWUDBEnt();
            List<product> data = context.products.ToList();
            return View(data);
        }

        public ActionResult Logout()
        {
            // Remove Session
            Session.RemoveAll();
            return RedirectToAction("Login", "Frontend");
        }
    }
}