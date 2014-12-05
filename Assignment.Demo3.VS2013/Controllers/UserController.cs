using System.Web.Mvc;
using Assignment.Demo3.Service.VS2013;

namespace Assignment.Demo3.VS2013.Controllers
{
    public class UserController : Controller
    {
        /// <summary>
        /// Create a new user
        /// </summary>
        /// <returns></returns>
        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Return the list of users created
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            var userList = new UserService().GetAllUsers();

            return View(userList);
        }

    }
}
