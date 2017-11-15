using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace _1.clSellingModel
{
    public class SellingContext:DbContext
    {
        public SellingContext():base("name=SellingContext")
        {
            Database.SetInitializer<SellingContext>(null);
        }
        public DbSet<tblOfficer> TblOfficer { get; set; }
        public DbSet<tblItem> TblItem { get; set; }
        public DbSet<tblSelling> TblSelling { get; set; }
        public DbSet<tblSellingDetail> TblSellingDetail { get; set; }
        public DbSet<MstUser> MstUser{ get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
