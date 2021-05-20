using MekashronProject.Interfaces;
using MekashronProject.Models;
using MekashronProject.Services;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MekashronProject.Controllers
{
    public class LoginController : Controller
    {
        LoginHandler _handler;
        public LoginController()
        {
            _handler = new LoginHandler(ServiceLocator.GetSoapService());
        }

        public ActionResult Index()
        {
            return View();
        }
    
        [HttpGet]
        [Route("GetOfUser/{login}/{password}")]
        public  ActionResult CheckLoginAsync(LoginCredentials req)
        {
            var result = _handler.LoginToSoapService(req);

            return Json(new { jobId = -1 });
        }
        //public ActionResult CheckLoginAsync(string login, string password)
        //{

        //    CheckLogin _loginService = new CheckLogin();
        //    IcutechService.IICUTech cl = new IcutechService.ICUTechClient();


        //    var check = cl.LoginAsync(new IcutechService.LoginRequest(login, password, "77.88.8.8"));

        //    //IcutechService.LoginResponse response = await _loginService.GetUser(login, password);
        //    //return Json(new { jobId = -1 });
        //    return View();
        //}
    }
}