using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Managers;

namespace Web.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int empTypeID)
        {
            IEmployeeManager mngr = null;
            
            if (empTypeID == 1) 
            {
                mngr = new PermanentEmployeeManager();
            }
            else if (empTypeID == 2)
            {
                mngr = new ContractualEmployeeManager();
            }

            return mngr;
        }
    }
}