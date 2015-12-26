using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DateSite.Controllers
{
    public class AccountController : Controller
    {

        public UsersRepository _usersRepository = new UsersRepository();

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(string name, string firstname, string lastname)
        {

            Profiles profile = new Profiles();
            profile.Firstname = firstname;
            profile.Lastname = lastname;
            profile.Gender = "Male";
            profile.Age = 22;
            profile.Id = 555;

            _usersRepository.insertUser(profile);

            return RedirectToAction("Index", "Home");
        }
    }
}