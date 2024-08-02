using AssignmentBookApp.Entities;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace AssignmentBookApp.Controllers
{

    public class BookController : Controller
    {
        private readonly BookAppContext bookAppContext;

        public BookController()
        {
            bookAppContext = new BookAppContext();  
        }
        public IActionResult Index() //Get All
        {
            var books = bookAppContext.Books.ToList();
            return View(books);
        }
        [HttpGet]
        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPost]

        public IActionResult AddBook(Book book)
        {
            if (ModelState.IsValid)
            {
                bookAppContext.Books.Add(book);
                bookAppContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(book);
            }
        }
       [HttpPost]
        public IActionResult GetBooksByAuthor(string author)
        {
            var book = bookAppContext.Books.Where(p => p.Author == author).ToList();
            return View("Index",book);
        }

        [HttpGet]
        //[Route("Lang")]
        public IActionResult GetBooksByLang(string lang)
        {
            if(ModelState.IsValid)
            {
                var book = bookAppContext.Books.Where(p=>p.Lang == lang).ToList();
                return View(book);
            }
            else
            {
                return View();
            }
        }
        /*public IActionResult GetBooksByYear(int year)
        {
            var book = bookAppContext.Books.Where(p => p.ReleaseDate.Year == year).ToList();
            return View(book);
        }*/
        public IActionResult Edit(int id) //only show the date data is not stored
        {
            var product = bookAppContext.Books.Single(p => p.BookId == id);
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                bookAppContext.Books.Update(book); //update record to product table (temp)
                bookAppContext.SaveChanges(); //To save changes Permanently
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var books = bookAppContext.Books.Single(p => p.BookId == id);
            return View(books);
        }
        [HttpPost]
        public IActionResult Delete(Book book)
        {
            bookAppContext.Books.Remove(book);
            bookAppContext.SaveChanges(); //To save changes Permanently
            return RedirectToAction("Index");
        }
    }
}
