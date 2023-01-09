using BusinessLayer_Uow.Abstract;
using DataAccessLayer_Uow.Abstract;
using DataAccessLayer_Uow.Entity_Framework;
using DataAccessLayer_Uow.UnitOfWork;
using EntityLayer_Uow.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer_Uow.Concrete
{
   public class ProcessDetailManager : IProcessDetailService
    {
        private readonly IProcessDetail _processdetailDal;
        private readonly IUowDal _uowDal;

        public ProcessDetailManager(IProcessDetail processdetailDal, IUowDal uowDal)
        {
            _processdetailDal = processdetailDal;
            _uowDal = uowDal;
        }

        public void TDelete(ProcessDetail t)
        {
            _processdetailDal.Delete(t);
            _uowDal.Save();
        }

        public ProcessDetail TGetByID(int id)
        {
            return _processdetailDal.GetByID(id);
        }

        public List<ProcessDetail> TGetList()
        {
            return _processdetailDal.GetList();
        }

        public void TInsert(ProcessDetail t)
        {
            _processdetailDal.Insert(t);
            _uowDal.Save();
        }

        public void TMultiUpdate(List<ProcessDetail> t)
        {
            _processdetailDal.MultiUpdate(t);
            _uowDal.Save();
        }

        public void TUpdate(ProcessDetail t)
        {
            _processdetailDal.Update(t);
            _uowDal.Save();
        }
    }
}
