using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WishList.Data;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View("Index");
        }
        [HttpGet]
        public IActionResult Create()
        {

            return View("Create");
        }
        [HttpPost]
        public IActionResult Create(WishList.Models.Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return View("Index");
        }
        public IActionResult Delete(int Id)
        {
            _context.SaveChanges();
            return View("Index");
        }
    }
}

