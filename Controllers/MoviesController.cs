using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
      //GET: Movies/Random
      public ActionResult Random()
      {
        var movie = new Movie() {Name = "Shrek!"};
        return View(movie);
      }
    }
}