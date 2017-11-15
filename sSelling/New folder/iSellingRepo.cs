using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.clSellingRepo
{
    interface iSellingRepo<Sellings>
    {
        bool Create(Sellings model);
        bool Update(Sellings model);
        bool Delete(string model);
        List<Sellings> GetAll();
        Sellings GetById(string cd);
    }
}
