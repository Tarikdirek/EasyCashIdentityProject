using EasyCashIdentityProject.BusinessLayer.Abstract;
using EasyCashIdentityProject.DataAccessLayer.Abstract;
using EasyCashIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinessLayer.Concrete
{
    public class CostumerAccountProcessManager : ICostumerAccountProcessService
    {
        ICostumerAccountProcessDal _costumerAccountProcessDal;

        public CostumerAccountProcessManager(ICostumerAccountProcessDal costumerAccountProcessDal)
        {
            _costumerAccountProcessDal = costumerAccountProcessDal;
        }

        public void TDelete(CostumerAccountProcess t)
        {
            _costumerAccountProcessDal.Delete(t);
        }

        public CostumerAccountProcess TGetByID(int id)
        {
            return _costumerAccountProcessDal.GetByID(id);
        }

        public List<CostumerAccountProcess> TGetList()
        {
           return  _costumerAccountProcessDal.GetList();
        }

        public void TInsert(CostumerAccountProcess t)
        {
            _costumerAccountProcessDal.Insert(t);
        }

        public void TUpdate(CostumerAccountProcess t)
        {
           _costumerAccountProcessDal.Update(t);
        }
    }
}
