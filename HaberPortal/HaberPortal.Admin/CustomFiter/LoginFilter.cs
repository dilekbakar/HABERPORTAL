using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace HaberPortal.Admin.CustomFiter
{
    public class LoginFilter : FilterAttribute, IActionFilter
    {

        //Action method çalıştırıldıktan sonra devreye girer.
        public void OnActionExecuted(ActionExecutedContext context)
        {
            HttpContextWrapper wrapper = new HttpContextWrapper(HttpContext.Current);
            //session kontrol.
            var SessionControl = context.HttpContext.Session["KullaniciEMail"];
            if (SessionControl == null)
            {
                //kullanıcı email sessionı boş ise bizi buraya yönlendirecek. boş değilse yönetim paneline devam edebilir.
                context.Result = new RedirectToRouteResult(
                    new RouteValueDictionary { { "controller", "Account" }, { "action", "Login" } });
            }
        }


        //Action method tetiklendiği anda devreye girer.
        public void OnActionExecuting(ActionExecutingContext context)
        {
        }
    }
}