using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;
using tr.Models.Transport;

namespace tr.Controllers
{
    public class TransportController : Controller
    {
        private readonly TransportContext _context;

        public TransportController(TransportContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var variable = _context.Transports.ToList();
            return View(variable);
        }

        public IActionResult Details(int id)
        {
            var transport = _context.Transports.FirstOrDefault(s => s.ID == id);
            return View(transport);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TransportModel transport)
        {
            if (ModelState.IsValid)
            {
                _context.Transports.Add(transport);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(transport);
        }

        public IActionResult Edit(int id)
        {
            var transport = _context.Transports.FirstOrDefault(s => s.ID == id);
            return View(transport);
        }

        [HttpPost]
        public IActionResult Edit(TransportModel transport)
        {
            if (ModelState.IsValid)
            {
                _context.Update(transport);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(transport);
        }

        public IActionResult Delete(int id)
        {
            var transport = _context.Transports.FirstOrDefault(s => s.ID == id);
            return View(transport);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var transport = _context.Transports.FirstOrDefault(s => s.ID == id);
            if (transport != null)
            {
                _context.Transports.Remove(transport);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
