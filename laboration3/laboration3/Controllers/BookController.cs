using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using laboration3.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;

namespace laboration3.Controllers
{
    public class BookController : Controller
    {

        [HttpGet]
        public IActionResult NewBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewBook(BookDetail bd)
        {
            UserMethod um = new UserMethod();
            string usr = HttpContext.Session.GetString("currentuser");
            UserDetail currentUser = JsonConvert.DeserializeObject<UserDetail>(usr);
            int id = currentUser.Id;
            BookMethod bm = new BookMethod();
            int i = 0;
            string error = "";
            i = bm.NewBook(bd, id, out error);
            ViewBag.error = error;
            ViewBag.antal = i;
            return View();
        }

        [HttpGet]
        public IActionResult Booklist()
        {
            List<BookDetail> Booklist = new List<BookDetail>();
            BookMethod bm = new BookMethod();
            Booklist = bm.GetBooks(out string error, "");
            ViewBag.error = error;
            return View(Booklist);
        }

        [HttpPost]
        public IActionResult Booklist(string Titel)
        {
            int i = Convert.ToInt32(Titel);
            List<BookDetail> Booklist = new List<BookDetail>();
            BookMethod bm = new BookMethod();
            Booklist = bm.FilterBooks(out string error, i);
            ViewBag.error = error;
            return View(Booklist);
        }

        [HttpPost]
        public IActionResult OrderBooks(string Order)
        {
            List<BookDetail> Booklist = new List<BookDetail>();
            BookMethod bm = new BookMethod();
            Booklist = bm.GetBooks(out string error, Order);
            ViewBag.error = error;
            return View("Booklist", Booklist);
        }

        [HttpGet]
        public IActionResult SearchedList(string s)
        {
            ViewBag.s = s;
            List<BookDetail> Booklist = new List<BookDetail>();
            BookMethod bm = new BookMethod();
            Booklist = bm.GetBooksBySearch(s, out string error);
            ViewBag.error = error;
            return View(Booklist);
        }

        [HttpGet]
        public IActionResult SeeBook(int id)
        {
            BookDetail bd = new BookDetail();
            BookMethod bm = new BookMethod();
            bd = bm.GetBook(id, out string error);
            ViewBag.error = error;
            return View(bd);
        }

        [HttpGet]
        public IActionResult EditBook(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult EditBook(int id, BookDetail bd)
        {
            BookMethod bm = new BookMethod();
            int i = 0;
            string error = "";
            bd.Id = id;
            i = bm.EditBook(bd, out error);
            ViewBag.error = error;
            if (i == 1) { return RedirectToAction("Booklist"); }
            else { return View();  }
        }

        [HttpGet]
        public IActionResult DeleteBook(int id)
        {
            BookMethod bm = new BookMethod();
            int i = 0;
            i = bm.DeleteBook(id, out string error);
            ViewBag.error = error;
            ViewBag.antal = i;
            return RedirectToAction("Booklist");
        }
    }
}
