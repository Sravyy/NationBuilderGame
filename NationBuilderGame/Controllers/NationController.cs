//using System;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Authorization;
//using NationBuilderGame.Models;
//using Microsoft.AspNetCore.Identity;
//using System.Security.Claims;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;



//namespace NationBuilderGame.Controllers
//{   
//    [Authorize]
//    public class NationController : Controller
//    {
//        private readonly ApplicationDbContext _db;
//        private readonly UserManager<ApplicationUser> _userManager;

//        public NationController(UserManager<ApplicationUser> userManager, ApplicationDbContext db)
//        {
//            _userManager = userManager;
//            _db = db;
//        }

//        public async Task<IActionResult> Index()
//        {
//            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
//            var currentUser = await _userManager.FindByIdAsync(userId);
//            return View(_db.Nations.Where(x => x.User.Id == currentUser.Id));
//        }

//        public IActionResult Create()
//        {
//            return View();
//        }

//        //[HttpPost]
//        //public async Task<IActionResult> Create(Nation nation)
//        //{
//        //    var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
//        //    var currentUser = await _userManager.FindByIdAsync(userId);
//        //    nation.User = currentUser;
//        //    _db.Nations.Add(nation);
//        //    _db.SaveChanges();
//        //    return RedirectToAction("Index");
//        //}
//    }
//}
