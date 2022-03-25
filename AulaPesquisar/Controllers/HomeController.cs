using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AulaPesquisar.Controllers
{
    public class HomeController : Controller
    {
       
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
        
    }
}
