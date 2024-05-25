using Loogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class BaseController : Controller
    {
        private Ilog _iLog;

        public BaseController()
        {
            _iLog = Log.Getnstance();
        }
        protected override void OnException(ExceptionContext filterContext)
        {
            //for checking threadsafety
            //Parallel.Invoke(() => _iLog.LogException(filterContext.Exception.ToString()),
            //    () => _iLog.LogException(filterContext.Exception.ToString()));

            //normal call
            _iLog.LogException(filterContext.Exception.ToString());

            filterContext.ExceptionHandled = true;
            this.View("Error").ExecuteResult(this.ControllerContext);
        }
    }
}