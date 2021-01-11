﻿using Microsoft.AspNetCore.Mvc;
using SFA.DAS.FindEpao.Web.Infrastructure;

namespace SFA.DAS.FindEpao.Web.Controllers
{
    public class HomeController : Controller
    {
        [Route("", Name = RouteNames.ServiceStartDefault, Order = 0)]
        [Route("start", Name = RouteNames.ServiceStart, Order = 1)]
        public IActionResult Index()
        {
            return View();
        }

        [Route("cookies", Name = RouteNames.Cookies)]
        public IActionResult Cookies()
        {
            return View();
        }

        [Route("cookies-details", Name = RouteNames.CookiesDetails)]
        public IActionResult CookiesDetails()
        {
            return View();
        }
    }
}
