using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2.SellingView;
using _1.clSellingModel;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;


namespace _3.clSellingRepo
{
    public class cMstUserRepo
    {
        private SellingContext sellingContext=new SellingContext();
        public List<cMstUserView> GetAll(cMstUserView dataLogin)
        {
            List<cMstUserView> result = new List<cMstUserView>();
            result=(from user in sellingContext.MstUser
                        join officer in sellingContext.TblOfficer
                            on user.OfficerCode equals officer.OfficerCode
                        where user.Username==dataLogin.Username
                        &&user.Password==dataLogin.Password
                        select new cMstUserView
                        {
                        ID=user.ID,
                        Username=user.Username,
                        Password=user.Password,
                        Active=user.Active,
                        OfficerCode=user.OfficerCode,
                        OfficerName=officer.OfficerName}).ToList();
            return result;
            
            
        }
    }
}
