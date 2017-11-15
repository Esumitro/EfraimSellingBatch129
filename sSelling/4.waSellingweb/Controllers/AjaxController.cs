using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _3.clSellingRepo;

namespace _4.waSellingweb.Controllers
{
    public class AjaxController : Controller
    {
        tblOfficerRevo serviceOfficer = new tblOfficerRevo();
        tblItemRevo serviceItem = new tblItemRevo();
        ctblSellingRevo serviceSelling = new ctblSellingRevo();
        ctblSellingDetailRevo serviceSellingDetail = new ctblSellingDetailRevo();

        
        //
        // GET: /Ajax/
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetListOfficer()
        {
            return PartialView("_GetListOfficer",serviceOfficer.GetAll());
        }
        public ActionResult GetListItem()
        {
            return PartialView("_GetListItem", serviceItem.GetAll());
        }
        public ActionResult GetListSelling()
        {
            return PartialView("_GetListSelling", serviceSelling.GetAll());
        }
        public ActionResult GetListSellingDetail()
        {
            return PartialView("_GetListSellingDetail", serviceSellingDetail.GetAll());
        }
        public ActionResult AddDataOfficer()
        {
            return PartialView("_AddDataOfficer");
        }
        public ActionResult EditDataOfficer(string cd)
        {
            return PartialView("_EditDataOfficer",serviceOfficer.GetById(cd));
        }
        public ActionResult AddDataItem()
        {
            return PartialView("_AddDataItem");
        }
        public ActionResult EditDataItem(string cd)
        {
            return PartialView("_EditDataItem", serviceItem.GetById(cd));
        }
	}
}