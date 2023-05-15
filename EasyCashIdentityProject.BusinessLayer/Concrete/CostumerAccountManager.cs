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
    public class CostumerAccountManager : ICostumerAccountService
    {
        ICostumerAccountDal _costumerAccountDal;

        public CostumerAccountManager(ICostumerAccountDal costumerAccountDal)
        {
            _costumerAccountDal = costumerAccountDal;
        }

        public void TDelete(CostumerAccount t)
        {
            _costumerAccountDal.Delete(t);
        }

        public CostumerAccount TGetByID(int id)
        {
            return _costumerAccountDal.GetByID(id);
        }

        public List<CostumerAccount> TGetList()
        {
            return _costumerAccountDal.GetList();
        }

        public void TInsert(CostumerAccount t)
        {
            _costumerAccountDal.Insert(t);
        }

        public void TUpdate(CostumerAccount t)
        {
           _costumerAccountDal.Update(t);
        }
    }
}
