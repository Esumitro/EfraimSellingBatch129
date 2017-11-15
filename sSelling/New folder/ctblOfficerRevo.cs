using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.SellingView;
using _1.clSellingModel;

namespace _3.clSellingRepo
{
    public class tblOfficerRevo:iSellingRepo<tblOfficerView>
    {
        private SellingContext SellingContex = new SellingContext();
        public bool Create(tblOfficerView model)
        {
            bool result = true;
            tblOfficer mdlOfficer = new tblOfficer();
            mdlOfficer.tblOfficerID = model.tblOfficerID;
            mdlOfficer.OfficerCode = model.OfficerCode;
            mdlOfficer.OfficerName = model.OfficerStatus;
            mdlOfficer.OfficerPassword = model.OfficerPassword;
            mdlOfficer.OfficerStatus = model.OfficerStatus;

            SellingContex.TblOfficer.Add(mdlOfficer);
            try
            {
                SellingContex.SaveChanges();
                return result;
            }
            catch (Exception )
            {
                result = false;
                return result;                
            }
            //return result;
        }
        public bool Update(tblOfficerView model)
        {
             bool result = true;
            tblOfficer mdlOfficer = SellingContex.TblOfficer.Where(mdl=>mdl.OfficerCode == model.OfficerCode).FirstOrDefault();
            mdlOfficer.tblOfficerID = model.tblOfficerID;
            mdlOfficer.OfficerCode = model.OfficerCode;
            mdlOfficer.OfficerName = model.OfficerStatus;
            mdlOfficer.OfficerPassword = model.OfficerPassword;
            mdlOfficer.OfficerStatus = model.OfficerStatus;

            SellingContex.TblOfficer.Add(mdlOfficer);
            try
            {
                SellingContex.SaveChanges();
                return result;
            }
            catch (Exception ex)
            {
                throw ex;
                result = false;
                return result;
                
            }
        }
        public bool Delete(string cdOfficer)
        {
            bool result = true;
            tblOfficer mdlOfficer = SellingContex.TblOfficer.Where(mdl => mdl.OfficerCode == mdl.OfficerCode).FirstOrDefault();
            SellingContex.TblOfficer.Remove(mdlOfficer);
            try
            {
                SellingContex.SaveChanges();
                return result;
            }
            catch (Exception )
            {
                
                result = false;
                return result;

            }
        }
        public tblOfficerView GetById(string cd)
        {
            tblOfficerView result=new tblOfficerView();
            result=(from officer in SellingContex.TblOfficer
                        where officer.OfficerCode==cd
                        select new tblOfficerView
                        {
                            tblOfficerID=officer.tblOfficerID,
                        OfficerCode= officer.OfficerCode,
                        OfficerName=officer.OfficerName,
                        OfficerPassword=officer.OfficerPassword,
                        OfficerStatus=officer.OfficerStatus}).FirstOrDefault();
                        
            return result;
        }
        public List<tblOfficerView> GetAll()
        {
            List<tblOfficerView> result=new List<tblOfficerView>();
            result=(from officer in SellingContex.TblOfficer
                        select new tblOfficerView{
                        tblOfficerID=officer.tblOfficerID,
                        OfficerCode= officer.OfficerCode,
                        OfficerName=officer.OfficerName,
                        OfficerPassword=officer.OfficerPassword,
                        OfficerStatus=officer.OfficerStatus}).ToList();
            return result;
        }


        
    }
}
