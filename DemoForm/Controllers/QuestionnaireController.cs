using DemoForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoForm.Controllers
{
    public class QuestionnaireController : Controller
    {
        public ActionResult Create()
        {
            var viewModel = Enumerable.Range(1, 10).Select(p => new Topic() { Sort = p }).ToArray();
            return View(viewModel);
        }
    }
}