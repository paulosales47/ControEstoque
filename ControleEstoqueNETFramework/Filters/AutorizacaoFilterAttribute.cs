using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ControleEstoqueNETFramework.Filters
{
    public class AutorizacaoFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var usuarioLogado = filterContext.HttpContext.Session["usuarioLogado"];

            if(usuarioLogado is null)
            {
                filterContext.Result = new RedirectToRouteResult(
                    new RouteValueDictionary (
                            new { action = "Index", controller = "Login" }));
            }
        }
    }
}