using Business.Abstract;
using DataAccess.Entity;
using DTO.EntityDTO;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace WebApplicationEuroDoor.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUserService _user;

        public LoginController(IUserService user)
        {
            _user = user;
        }

        #region Login
        [HttpGet]
        public IActionResult Login()
        {
    

            return View();
        }

        public IActionResult LoginCheck(UserDTO p)
        {
            var value=_user.GetAllInclude().Where(x=>x.UserName.ToLower() == p.UserName).FirstOrDefault();
            if (value == null)
            {
                return ValidationProblem();
            }
            if (value.Password.ToLower() == p.Password && value.Role.Name == "Admin")
            {
				return RedirectToAction("Product", "Admin");
			}
            else if (value.Password == p.Password && value.Role.Name == "Satici")
            {
                return RedirectToAction("SalerProduct", "Saler");
            }
            else if (value.Password == p.Password && value.Role.Name == "Moderator")
            {
                return RedirectToAction("ModeratorProduct", "Moderator");
            }
            else
            {
                return RedirectToAction("Login");
            }
            

        }

        #endregion
    }
}
