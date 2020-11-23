using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Data;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.Users = UserData.GetAll();
      
            return View();
        }

        [HttpPost]
        [HttpGet]
        public IActionResult Add(User newUser, string ConfirmPassword)
        {
            if (ConfirmPassword != null)
            {
                if (newUser.Password == ConfirmPassword)
                {
                    DateTime localDate = DateTime.Now;
                    newUser.Now = localDate;
                    UserData.Add(newUser);
                    return Redirect("/User");

                }

                else
                {
                    ViewBag.Error = "Password fields must match!";
                    ViewBag.UserName = newUser.UserName;
                    ViewBag.Email = newUser.Email;
                }
            }

             return View();
        }
    }
}
