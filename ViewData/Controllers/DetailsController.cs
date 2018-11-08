using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewData.Models.Details;

namespace ViewData.Controllers
{
    public class DetailsController : Controller
    {

    public IActionResult Index()
        {
            ViewData["Name"] = "archana";
            ViewData["Phone"] = "Mi";
            ViewData["Address"] = "jaipur";
            ViewData["Interest"] = "Reading";

            DataClass dataclass = new DataClass
            {
                Count = ViewData.Count,
                key = ViewData.Keys,
                Value = ViewData.Values

            };

            return View(dataclass);
        }
    }
}