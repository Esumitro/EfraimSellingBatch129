using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _2.SellingView;
using _3.clSellingRepo;
using _5.clSellingCommenly;
using System.Data;

namespace _4.waSellingweb.Controllers
{
    public class OfficerController : Controller
    {
        //
        // GET: /Officer/
        tblOfficerRevo serviceOfficer = new tblOfficerRevo();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tblOfficerView mode)
        {
            if (ModelState.IsValid)
            {
                string sp = " spomaxidofficer ";
                DataSet data = cCommon.ExecuteDataSet(sp);
                int id = data.Tables[0].Rows[0].Field<int>("MaxID");
                mode.tblOfficerID = id + 1;
                if (serviceOfficer.Create(mode))
                {
                    return Json(new { pesan = "Sukses" }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { pesan = "Gagal!" }, JsonRequestBehavior.AllowGet);
                }
            }
            return View();
        }
        public ActionResult Update(tblOfficerView model)
        {
            if (ModelState.IsValid)
            {
                if (serviceOfficer.Update(model))
                {
                    return Json(new { pesan = "Sukses" }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { pesan = "Gagal!" }, JsonRequestBehavior.AllowGet);
                }
            }
            return View();
        }
        public ActionResult Delete(string cdOfficer)
        {
            if (ModelState.IsValid)
            {
                if (serviceOfficer.Delete(cdOfficer))
                {
                    return Json(new { pesan = "Sukses" }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { pesan = "Gagal!" }, JsonRequestBehavior.AllowGet);
                }
            }
            return View();
        }
    }
}