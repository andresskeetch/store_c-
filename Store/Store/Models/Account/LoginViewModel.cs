using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Store.Models.Account
{
    public class LoginViewModel
    {
        public int Code { get; set; }
        [Required(ErrorMessageResourceName = "AccountLoginErrorUsernameRequired", ErrorMessageResourceType = typeof(Resources.Resource))]
        [EmailAddress]
        [Display(Name = "UserName")]
        public string UserName { get; set; }
        [Required(ErrorMessageResourceName = "AccountLoginErrorPasswordRequired", ErrorMessageResourceType = typeof(Resources.Resource))]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}