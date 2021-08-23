using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ANC_2_1210823_FrontStudy.Controllers
{
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[Route({id})]
        public IActionResult HrefView(string button_id)
        {
            return View("./" + button_id);
        }
    }
}