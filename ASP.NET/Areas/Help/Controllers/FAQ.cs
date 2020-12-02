using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CIS_420_Project.Areas.Help.Controllers
{
    public class FAQController : Controller
    {
        [Area("Help")]
        public IActionResult Main()
        {
            
            return View();
        }

    }
}
