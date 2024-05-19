using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Managers
{
    public class ContractualEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 50;
        }

        public decimal GetHourlyPay()
        {
            return 100;
        }
    }
}