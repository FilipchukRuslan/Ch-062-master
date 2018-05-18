using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class EmailMessagesController : Controller
    {
        public IActionResult Email()
        {
            return View();
        }
    }
}