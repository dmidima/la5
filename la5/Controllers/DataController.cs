using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using la5.Models;
using Microsoft.EntityFrameworkCore;
using la5.Data;

namespace la5.Controllers
{
    public class DataController : Controller
    {
        PeopleDb db;
        public DataController(PeopleDb db)
        {
            this.db = db;
        }

        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Index()
        {
            var PeopleData = await db.Peoples.ToListAsync();
            return View(PeopleData);
        }

        [Authorize(Roles = "admin")]
        public IActionResult Create()

        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(PeopleModel user)
        {
            db.Peoples.Add(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
