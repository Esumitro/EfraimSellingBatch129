using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.SellingView;
using _1.clSellingModel;

namespace _3.clSellingRepo
{
    public class ctblSellingDetailRevo : iSellingRepo<ctblSellingDetailView>
    {
        private SellingContext SellingContex = new SellingContext();
        public bool Create(ctblSellingDetailView model)
        {
            bool asd = true;
            return asd;
        }
        public bool Update(ctblSellingDetailView model)
        {
            bool asd = true;
            return asd;
        }
        public bool Delete(string model)
        {
            bool asd = true;
            return asd;
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
