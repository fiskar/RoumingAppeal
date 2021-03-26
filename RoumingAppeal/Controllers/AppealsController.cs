using Microsoft.AspNetCore.Mvc;
using RoumingAppeal.Interfaces;
using RoumingAppeal.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoumingAppeal.Controllers
{
    public class AppealsController : Controller
    {
        private readonly IAppeal _appeals;
        private readonly ISourceAppeal _sourceAppeals;

        public AppealsController(IAppeal iAppeals, ISourceAppeal iSourceAppeals)
        {
            _appeals = iAppeals;
            _sourceAppeals = iSourceAppeals;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Страница с обращениями";
            AppealsListViewModel obj = new AppealsListViewModel();
            obj.allAppeals = _appeals.AllAppeals;
            obj.currentSource ="Источники обращений";
            return View(obj);

        }
    }
}
