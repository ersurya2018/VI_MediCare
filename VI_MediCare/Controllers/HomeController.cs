using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VI_MediCare.Models;
using VI_MediCare_Manager.Login;

namespace VI_MediCare.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ILogin_Mgr _loginMgr;

        public HomeController(ILogin_Mgr loginMgr, ILogger<HomeController> logger)
        {
            _loginMgr = loginMgr;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var data=_loginMgr.GetName();
            return View();
        }

    }
}
