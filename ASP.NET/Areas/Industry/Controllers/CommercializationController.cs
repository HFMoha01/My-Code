using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CIS_420_Project.Areas.Industry.Controllers
{
    public class CommercializationController : Controller
    {
        [Area("Industry")]
        public IActionResult Main()
        {
            return View();
        }
    }
}
