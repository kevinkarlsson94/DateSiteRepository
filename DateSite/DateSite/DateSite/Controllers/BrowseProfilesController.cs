using System.Web.Mvc;
using Repositories;
using DateSite.Functions;

namespace DateSite.Controllers
{
    public class BrowseProfilesController : Controller
    {
        private UsersRepository _usersRepository;
        public readLocalTextFile reader = new readLocalTextFile();

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