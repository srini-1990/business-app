
//using BusinessApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace BusinessApp_.Controllers
{
    public class HomeController : Controller
    {



        public ActionResult Index()
        {
            return View();
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Booking()
        {
            ViewBag.Message = "Your contact page.";

            return View("_Booking");
        }

        public ActionResult Members()
        {
            ViewBag.Message = "Your contact page.";

            return View("Members");

        }

        // GET: Members
        //public ActionResult Members()
        //{
        //    CustomersEntities entities = new CustomersEntities();
        //    return View(entities.Customers);
        //}

        //public JsonResult InsertCustomers(List<Customer> customers)
        //{
        //    using (CustomersEntities entities = new CustomersEntities())
        //    {
        //        //Truncate Table to delete all old records.
        //        entities.Database.ExecuteSqlCommand("TRUNCATE TABLE [Customers]");

        //        //Check for NULL.
        //        if (customers == null)
        //        {
        //            customers = new List<Customer>();
        //        }

        //        //Loop and insert records.
        //        foreach (Customer customer in customers)
        //        {
        //            entities.Customers.Add(customer);
        //        }
        //        int insertedRecords = entities.SaveChanges();
        //        return Json(insertedRecords);
        //    }
    }
}


