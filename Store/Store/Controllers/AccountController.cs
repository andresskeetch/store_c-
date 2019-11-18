using Store.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Store.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        // GET: Account
        public ActionResult Index(string ReturnUrl)
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginViewModel model, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                SetAuthCookie(model);
            }
            return View();
        }

        private void SetAuthCookie(LoginViewModel model)
        {
            Response.Cookies.Add(Helpers.Security.SetAuthCookie(model));
        }
    }


}