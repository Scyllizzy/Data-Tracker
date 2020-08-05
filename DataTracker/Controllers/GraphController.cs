using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace DataTracker.Controllers
{
    public class GraphController : Controller
    {
        public IActionResult CreateGraph()
        {
            return View();
        }
    }
}
