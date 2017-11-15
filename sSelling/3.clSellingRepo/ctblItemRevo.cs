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
            bool result = true;
            tblItem mdlItem = new tblItem();
            mdlItem.tblItemID = model.tblItemID;
            mdlItem.ItemCode = model.ItemCode;
            mdlItem.ItemName = model.ItemName;
            mdlItem.BuyingPrice = model.BuyingPrice;
            mdlItem.SellingPrice = model.SellingPrice;
            mdlItem.ItemAmount = model.ItemAmount;
            mdlItem.Pieces = model.Pieces;

            SellingContex.TblItem.Add(mdlItem);
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
            //return result;
        }
        public bool Update(ctblItemView model)
        {
            bool result = true;
            tblItem mdlItem = SellingContex.TblItem.Where(mdl => mdl.ItemCode == model.ItemCode).FirstOrDefault();
            mdlItem.tblItemID = model.tblItemID;
            mdlItem.ItemCode = model.ItemCode;
            mdlItem.ItemName = model.ItemName;
            mdlItem.BuyingPrice = model.BuyingPrice;
            mdlItem.SellingPrice = model.SellingPrice;
            mdlItem.ItemAmount = model.ItemAmount;
            mdlItem.Pieces = model.Pieces;

            SellingContex.TblItem.Add(mdlItem);
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
            //return asd;
        }
        public bool Delete(string cdItem)
        {
            bool result = true;
            tblItem mdlItem = SellingContex.TblItem.Where(mdl => mdl.ItemCode == cdItem).FirstOrDefault();
            SellingContex.TblItem.Remove(mdlItem);
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
        public ctblItemView GetById(string cd)
        {
            ctblItemView result = new ctblItemView();
            result = (from item in SellingContex.TblItem
                      where item.ItemCode == cd
                      select new ctblItemView
                      {
                          tblItemID = item.tblItemID,
                          ItemCode = item.ItemCode,
                          ItemName = item.ItemName,
                          BuyingPrice = item.BuyingPrice,
                          SellingPrice = item.SellingPrice,
                          ItemAmount = item.ItemAmount,
                          Pieces = item.Pieces
                      }).FirstOrDefault();
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
                          Pieces = item.Pieces
                      }).ToList();
            return result;
        }

        public int tblItemID { get; set; }

        //public bool Create(tblItemRevo mode)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
