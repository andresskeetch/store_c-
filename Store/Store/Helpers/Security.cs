using Store.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Store.Helpers
{
    public static class Security
    {
        public static HttpCookie SetAuthCookie(LoginViewModel login)
        {
            HttpCookie cookie = FormsAuthentication.GetAuthCookie(login.UserName, true);
            FormsAuthenticationTicket tkt = FormsAuthentication.Decrypt(cookie.Value);

            tkt = new FormsAuthenticationTicket(tkt.Version, login.UserName, tkt.IssueDate, tkt.Expiration, true, login.UserName);

            string enc = FormsAuthentication.Encrypt(tkt);
            cookie.Value = enc;
            return cookie;
        }
    }
}