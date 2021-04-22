using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookInventory.Controllers
{
    public class Homepage : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
