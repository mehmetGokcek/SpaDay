using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SpaDay.Data;
using SpaDay.Models;
using SpaDay.ViewModels;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            List<User> users= new List<User>(UserData.GetAll());

            return View(users);
        }

        public IActionResult Add()
        {
            return View();
        }




        [HttpPost]
        public IActionResult Add(AddUserViewModel addUserViewModel)
        {
            if (ModelState.IsValid)
            {

                User newUser = new User
                {
                    Username = addUserViewModel.Username,
                    Email = addUserViewModel.Email,
                    Password = addUserViewModel.Password,
                    Now = DateTime.Now

                };

                UserData.Add(newUser);
                return Redirect("/user");
            }

            else
            {
                return View(addUserViewModel);
            }

        }



    }
}
