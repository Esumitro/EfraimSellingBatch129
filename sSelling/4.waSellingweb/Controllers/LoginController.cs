using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _3.clSellingRepo;
using _2.SellingView;

namespace _4.waSellingweb.Controllers
{
    public class LoginController : Controller
    {
        cMstUserRepo serviceUser = new cMstUserRepo();
        //
        // GET: /Login/
        public ActionResult Index()
        {
            //Session["Username"] = "Bima";
            return View();
        }
        [HttpPost]
        public ActionResult Login(cMstUserView dataLogin)
        {
            var modelUser = serviceUser.GetAll(dataLogin);
            if (modelUser.Count == 0)
            {
                ViewBag.error = "Username atau Password Salah";
                return View("Index");
            }
            else
            {
                if (modelUser[0].Active.ToString() == "True")
                {
                    Session["Username"] = modelUser[0].Username;
                    Session["Role"] = modelUser[0].Username;
                    Session["EmployeeName"] = modelUser[0].OfficerName;
                    return Json(new
                    {
                        msg = "success"
                    }, JsonRequestBehavior.AllowGet);
                }
            }
            return View();
        }
    }
}