using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.SellingView;
using _1.clSellingModel;

namespace _3.clSellingRepo
{
    public class ctblSellingRevo : iSellingRepo<ctblSellingView>
    {
        private SellingContext SellingContex = new SellingContext();
        public bool Create(ctblSellingView model)
        {
            bool asd = true;
            return asd;
        }
        public bool Update(ctblSellingView model)
        {
            bool asd = true;
            return asd;
        }
        public bool Delete(string cd)
        {
            bool result = true;
            tblSelling mdlSelling = SellingContex.TblSelling.Where(mdl => mdl.Invoice == cd).FirstOrDefault();
            SellingContex.TblSelling.Remove(mdlSelling);
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
        public ctblSellingView GetById(string cd)
        {
            ctblSellingView result = new ctblSellingView();
            result = (from selling in SellingContex.TblSelling
                      select new ctblSellingView
                      {
                          tblSellingID = selling.tblSellingID,
                          Invoice = selling.Invoice,
                          InvoiceData = selling.InvoiceData,
                          Item = selling.Item,
                          Total = selling.Total,
                          Paid = selling.Paid,
                          Return = selling.Return,
                          OfficerCode = selling.OfficerCode
                      }).FirstOrDefault();
            return result;
        }
        public List<ctblSellingView> GetAll()
        {
            List<ctblSellingView> result = new List<ctblSellingView>();
            result = (from selling in SellingContex.TblSelling
                      select new ctblSellingView
                      {
                          tblSellingID = selling.tblSellingID,
                          Invoice = selling.Invoice,
                          InvoiceData = selling.InvoiceData,
                          Item = selling.Item,
                          Total = selling.Total,
                          Paid = selling.Paid,
                          Return = selling.Return,
                          OfficerCode = selling.OfficerCode
                      }).ToList();
            return result;
        }
    }
}
