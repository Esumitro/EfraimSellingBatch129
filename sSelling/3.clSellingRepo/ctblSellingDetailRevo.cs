using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.SellingView;
using _1.clSellingModel;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace _3.clSellingRepo
{
    public class ctblSellingDetailRevo : iSellingRepo<ctblSellingDetailView>
    {
        private SellingContext SellingContex = new SellingContext();
        public bool Create(ctblSellingDetailView model)
        {
            bool result = true;
            tblSellingDetail mdlSDetail = new tblSellingDetail();
            mdlSDetail.tblSellingDetailID = model.tblSellingDetailID;
            mdlSDetail.Invoice = model.Invoice;
            mdlSDetail.ItemCode = model.ItemCode;
            mdlSDetail.ItemName = model.ItemName;
            mdlSDetail.ItemPrice = model.ItemPrice;
            mdlSDetail.SubTotal = model.SubTotal;
            SellingContex.TblSellingDetail.Add(mdlSDetail);
            try
            {
                SellingContex.SaveChanges();
                return result;
            }
            catch (Exception)
            {
                result = false;
                return result;
            }
        }
        public bool Update(ctblSellingDetailView model)
        {
            bool result = true;
            tblSellingDetail mdlSDetail = SellingContex.TblSellingDetail.Where(mdl => mdl.tblSellingDetailID == model.tblSellingDetailID).FirstOrDefault();
            mdlSDetail.tblSellingDetailID = model.tblSellingDetailID;
            mdlSDetail.Invoice = model.Invoice;
            mdlSDetail.ItemCode = model.ItemCode;
            mdlSDetail.ItemName = model.ItemName;
            mdlSDetail.ItemPrice = model.ItemPrice;
            mdlSDetail.SubTotal = model.SubTotal;
            SellingContex.TblSellingDetail.Add(mdlSDetail);
            try
            {
                SellingContex.SaveChanges();
                return result;
            }
            catch (Exception)
            {
                result = false;
                return result;
            }
        }
        public bool Delete(string cdSDetail)
        {
            bool result = true;
            //tblSellingDetail mdlSDetail = SellingContex.TblSellingDetail.Where(mdl => mdl.tblSellingDetail ==cdSDetail).FirstOrDefault();            
            //SellingContex.TblSellingDetail.Remove(mdlSDetail);
            //try
            //{
            //    SellingContex.SaveChanges();
            //    return result;
            //}
            //catch (Exception)
            //{
            
            return result;
            //}
        }
        public ctblSellingDetailView GetById(string cd)
        {
            ctblSellingDetailView result = new ctblSellingDetailView();
            return result;
        }
        public List<ctblSellingDetailView> GetAll()
        {
            List<ctblSellingDetailView> result = new List<ctblSellingDetailView>();
            result = (from sdetail in SellingContex.TblSellingDetail
                      select new ctblSellingDetailView
                      {
                          tblSellingDetailID = sdetail.tblSellingDetailID,
                          Invoice = sdetail.Invoice,
                          ItemCode = sdetail.ItemCode,
                          ItemName = sdetail.ItemName,
                          ItemPrice = sdetail.ItemPrice,
                          SubTotal = sdetail.SubTotal

                      }).ToList();
            return result;
        }
    }
}
