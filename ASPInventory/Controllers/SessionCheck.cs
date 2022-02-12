﻿using System.Web.Mvc;
using System.Web;
using System.Web.Routing;

namespace ASPInventory.Controllers
{
    public class SessionCheck : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            HttpSessionStateBase session = filterContext.HttpContext.Session;
            if (session != null && session["Email"] == null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary
                    {
                        { "Controller", "Frontend" },
                        { "Action", "Login" }
                    });
            }
        }
    }
}