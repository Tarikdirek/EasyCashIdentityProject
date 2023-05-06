using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.EntityLayer.Concrete
{
    public class CostumerAccount
    {
        public int CostumerAccountID { get; set; }
        public string CostumerAccontNumber { get; set; }
        public string CostumerAccontCurrency { get; set; }
        public decimal CostumerAccontBalance { get; set; }
        public string BankBranch { get; set; }


    }
}
