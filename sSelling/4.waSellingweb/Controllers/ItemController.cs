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
    public class ItemController : Controller
    {
        //
        // GET: /Item/
        tblItemRevo serviceItem = new tblItemRevo();
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(ctblItemView mode)
        {
            if (ModelState.IsValid)
            {
                string sp = " spomaxiditem ";
                DataSet data = cCommon.ExecuteDataSet(sp);
                int id = data.Tables[0].Rows[0].Field<int>("MaxID");
                mode.tblItemID = id + 1;
                if (serviceItem.Create(mode))
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
        public ActionResult Update(ctblItemView model)
        {
            if (ModelState.IsValid)
            {
                if (serviceItem.Update(model))
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
        public ActionResult Delete(string cdItem)
        {
            if (ModelState.IsValid)
            {
                if (serviceItem.Delete(cdItem))
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