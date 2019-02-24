using Problemstatment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Problemstatment.Controllers
{
    public class LoginController : Controller
    {
        // GET: Userlogin

        [HttpPost]
        public bool DoLogin(UserLoginModel objUserLogin)
        {
            if (objUserLogin.UserName == "rashmitrivedi" && objUserLogin.Password == "rashmi123")
                return true;
            else
            {
                return false;
            }

        }

    }
}