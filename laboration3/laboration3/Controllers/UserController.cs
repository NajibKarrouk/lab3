using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using laboration3.Models;
using Newtonsoft.Json;

namespace laboration3.Controllers
{
    public class UserController : Controller
    {

        [HttpGet]
        public IActionResult NewUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewUser(UserDetail ud)
        {
            UserMethod um = new UserMethod();
            int i = 0;
            string error = "";
            i = um.NewUser(ud, out error);
            ViewBag.error = error;
            ViewBag.antal = i;
            return View();
        }

        [HttpGet]
        public IActionResult LoginUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginUser(UserDetail ud)
        {
            UserMethod um = new UserMethod();
            List<UserDetail> users = new List<UserDetail>();
            string error = "";
            users = um.GetUsers(out error);
            UserDetail currentUser = users.Find(user => user.Username == ud.Username);
            if (currentUser != null)
            {
                string usr = JsonConvert.SerializeObject(currentUser);
                HttpContext.Session.SetString("currentuser", usr);
                return View("UserSettings", currentUser);
            } else
            {
                ViewBag.error = "Inloggningsuppgifterna stämmer inte.";
                return View();
            }
        }

        [HttpGet]
        public IActionResult UserSettings()
        {
            UserMethod um = new UserMethod();
            string usr = HttpContext.Session.GetString("currentuser");
            UserDetail currentUser = JsonConvert.DeserializeObject<UserDetail>(usr);
            return View(currentUser);
        }

        [HttpGet]
        public IActionResult UpdateUser(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateUser(int id, UserDetail ud)
        {
            UserMethod um = new UserMethod();
            int i = 0;
            string error = "";
            ud.Id = id;
            i = um.UpdateUser(ud, out error);
            ViewBag.error = error;
            if (i == 1) {
                string usr = HttpContext.Session.GetString("currentuser");
                UserDetail currentUser = JsonConvert.DeserializeObject<UserDetail>(usr);
                currentUser.Username = ud.Username;
                currentUser.Password = ud.Password;
                usr = JsonConvert.SerializeObject(currentUser);
                HttpContext.Session.SetString("currentuser", usr);
                return RedirectToAction("UserSettings");
            }
            else { return View(); }
        }

        [HttpGet] 
        public IActionResult DeleteUser(int id)
        {
            UserMethod um = new UserMethod();
            int i = 0;
            i = um.DeleteUser(id, out string error);
            ViewBag.error = error;
            ViewBag.antal = i;
            return View("../Home/Index");
        }

    }
}
