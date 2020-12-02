using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CIS_420_Project.Areas.About.Controllers
{
    public class PoliciesController : Controller
    {
        [Area("About")]
        public IActionResult Main()
        {
            
            return View();
        }

    }
}
