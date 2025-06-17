using Microsoft.AspNetCore.Mvc;
using LAB3.Models;

namespace LAB3.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>()
        {
             new User() {id="1",username="aaa",password="1",phone="111",email="111"},
             new User() {id="1",username="aaa",password="1",phone="111",email="111"},
             new User() {id="1",username="aaa",password="1",phone="111",email="111"},
             new User() {id="1",username="aaa",password="1",phone="111",email="111"},
             new User() {id="1",username="aaa",password="1",phone="111",email="111"},
        };
        public IActionResult Index()
        {
            return View(users);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(User user)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    users.Add(user);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(user);
                }
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"Error: {ex.Message}");
                return View(user);
            }
        }

        [HttpGet]
        public IActionResult Edit(string id)
        {
            var user = users.FirstOrDefault(u => u.id == id);
            if (user == null)
            {
                return NotFound();
            }
            return View(user);
        }

        [HttpPost]
        public IActionResult Edit(User updatedUser)
        {
            if (ModelState.IsValid)
            {
                var user = users.FirstOrDefault(u => u.id == updatedUser.id);
                if (user != null)
                {
                    user.username = updatedUser.username;
                    user.password = updatedUser.password;
                    user.email = updatedUser.email;
                    user.phone = updatedUser.phone;
                }
                return RedirectToAction("Index");
            }
            return View(updatedUser);
        }

    }
}
