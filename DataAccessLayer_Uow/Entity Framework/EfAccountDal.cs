using DataAccessLayer_Uow.Abstract;
using DataAccessLayer_Uow.Concrete;
using DataAccessLayer_Uow.Repositories;
using EntityLayer_Uow.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer_Uow.Entity_Framework
{
    public class EfAccountDal:GenericRepository<Account>,IAccountDal
    {
        public EfAccountDal(Context context):base(context)
        {

        }
    }
}
