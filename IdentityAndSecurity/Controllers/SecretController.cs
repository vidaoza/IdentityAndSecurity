using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IdentityAndSecurity.Controllers
{
    [Authorize]  // Protects controller
    public class SecretController : Controller
    {
        // [Authorize]  // Protects Action
        public ContentResult Secret()
        {
            return Content("This is a secret");
        }

        [AllowAnonymous]  // Allows anonymous access
        public ContentResult Overt()
        {
            return Content("This is not a secret.");
        }
    }
}