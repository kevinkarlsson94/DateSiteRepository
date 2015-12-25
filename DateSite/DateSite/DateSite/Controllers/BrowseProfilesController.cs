using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Repositories;
using DateSite.Models;

namespace DateSite.Controllers
{
    public class BrowseProfilesController : Controller
    {

        private UsersRepository _usersRepository;

        public BrowseProfilesController()
        {
            _usersRepository = new UsersRepository();
        }

        // GET: BrowseProfiles
        public ActionResult Browse()
        {

            var userList = _usersRepository.fetchProfiles();
            return View(userList);
        }
    }
}