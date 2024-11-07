using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web.Mvc;
using EmployeeManagement.Models;

namespace EmployeeManagement.Controllers
{
    public class AccountController : Controller
    {
        // Database context
        private Manage db = new Manage();

        // GET: Account/Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken] // This ensures that the Anti-Forgery Token is validated
        public ActionResult LoginHandling(string username, string password)
        {
            // Validate if both username and password are entered
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                ModelState.AddModelError("", "Please enter both username and password.");
                return View("Login");
            }

            // Search for the user with the provided username and hashed password
            var user = db.tb_ACCOUNT.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                // Create session to store logged-in user information
                Session["UserID"] = user.AccountID;
                Session["Username"] = user.tb_EMPLOYEE.FullName;
                Session["Role"] = user.Role;

                if (user.Role == "Admin")
                {
                    return RedirectToAction("Index", "tb_EMPLOYEE");

                }
                else
                {
                    return RedirectToAction("Index", "tb_EMPLOYEE");
                }

            }
            else
            {
                // Add an error if the login credentials are incorrect
                ModelState.AddModelError("", "Invalid username or password.");
            }

            // Return to the Login view with error messages
            return View("Login");
        }

        public ActionResult logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
        

        // GET: Account Index (could be used for a logged-in user's dashboard or similar)
        public ActionResult Index()
        {
            return View();
        }
    }
}
