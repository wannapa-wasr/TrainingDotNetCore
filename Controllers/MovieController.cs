using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TrainingDotNetCoreMVC.Controllers
{
    public class MovieController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public string Welcome(string name, string id)
        {
            return $"Hello, Your name's {name}. Your ID is {id}.";
        }
    }
}
