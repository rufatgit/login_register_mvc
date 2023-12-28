using Microsoft.AspNetCore.Mvc;
using mvcapp.Data;
using mvcapp.Models;
using mvcapp.ViewModels;


namespace mvcapp.Controllers
{
    public class AccounController : Controller
    {
        public User _user => RouteData.Values["loginnedUser"] as User;

        private readonly mvcappDbContext _context;


        public AccounController(mvcappDbContext context)
        {
            _context = context;
        }


        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (_context.Users.Any(u => u.Email == model.Email))
            {
                ModelState.AddModelError("Email", "This email already has been used.");
            }


            if (ModelState.IsValid)
            {
                User user = new User
                {
                    Fullname = model.FullName,
                    Email = model.Email,
                    Password = model.Password,
                };

                _context.Users.Add(user);   
                _context.SaveChanges();




                return RedirectToAction("Index", "Home");

            }

            return View();

        }




        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User user = _context.Users.FirstOrDefault(u=>u.Email==model.Email);

                if (user!=null && user.Password==model.Password)
                {
                    _context.SaveChanges();
                    

                    return RedirectToAction("Index", "home");
                }
                ModelState.AddModelError("Password", "Email or Password is wrong");

            }
            return View(model);
        }

        public IActionResult LogOut()
        {
            _context.SaveChanges(); 
            return RedirectToAction("login");

        }



    }
}
