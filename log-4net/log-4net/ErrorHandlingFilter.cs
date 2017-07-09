namespace log_4net
{
    using log4net;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;

    public class ErrorHandlingFilter: HandleErrorAttribute
    {
        public ErrorHandlingFilter()
        {

        }
        public override void OnException(ExceptionContext filterContext)
        {
            string controllerName = (string)filterContext.RouteData.Values["controller"];

            string actionName = (string)filterContext.RouteData.Values["action"];

            ILog log = LogManager.GetLogger($"{controllerName}-{actionName}");

            log.Error(filterContext.Exception);
        }
    }
}