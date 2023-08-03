using Microsoft.AspNetCore.Mvc;
using MVC_Routing.Models;

namespace MVC_Routing.Controllers
{
    //Attribute
    [Route("Account")]
    public class UserAccountController : Controller
    {
        [Route("User")]
        public IActionResult Index()
        {
            UserInfoVM user = new UserInfoVM
            {
                UserName = "oguzkagan",
                Email = "xyz@xyz.com",
                InformationText = ".Net",
                Roles = new List<string> { "Yazılımcı", "Teknik Öğretmen", "Mühendis" }
            };

            return View(user);
        }

        //Parametreli Routing Kullanımı
        [Route("Parameters/{email}/{userName}/{informationText}")]
        public IActionResult Parameters(string email, string userName, string informationText)
        {
            UserInfoVM user = new UserInfoVM
            {
                Email = email,
                UserName = userName,
                InformationText = informationText
            };
            return View(user);
        }

        [HttpGet("UserCreate")] //Hiçbir şey yazılmazsa default olarak HTTPGET'dir.
        public IActionResult CreateUser()
        {
            return View();
        }

        [HttpPost("UserCreate")]
        public IActionResult CreateUser(UserFormVM model)
        {
            ViewBag.Message = "Kullanıcı Kaydedildi!!";
            return View();
        }
    }
}
