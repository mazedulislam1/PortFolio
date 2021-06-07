using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BdA.SocialNetwork.Web.Models
{
    public class AccountViewModel
    {
        public LoginModel LoginModel { get; set; }
        public RegisterModel RegisterModel { get; set; }
        //public string ReturnUrl { get; set; }
    }
}
