using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.SellingView;
using _1.clSellingModel;

namespace _3.clSellingRepo
{
    public class tblItemRevo : iSellingRepo<ctblItemView>
    {
        private SellingContext SellingContex = new SellingContext();
        public bool Create(ctblItemView model)
        {
            bool asd = true;
            return asd;
        }
        public bool Update(ctblItemView model)
        {
            bool asd = true;
            return asd;
        }
        public bool Delete(string model)
        {
            bool asd = true;
            return asd;
        }
        public ctblItemView GetById(string cd)
        {
            ctblItemView result = new ctblItemView();
            return result;
        }
        public List<ctblItemView> GetAll()
        {
            List<ctblItemView> result = new List<ctblItemView>();
            result = (from item in SellingContex.TblItem
                      select new ctblItemView
                      {
                          tblItemID = item.tblItemID,
                          ItemCode = item.ItemCode,
                          ItemName = item.ItemName,
                          BuyingPrice = item.BuyingPrice,
                          SellingPrice = item.SellingPrice,
                          ItemAmount = item.ItemAmount,
                          Pieces= item.Pieces
                      }).ToList();
            return result;
        }
    }
}
