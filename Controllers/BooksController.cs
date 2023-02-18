//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Film.Models;
//using Film.Models.Domain;
//using Film.Repositories.Abstract;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
//using Microsoft.EntityFrameworkCore;

//namespace Film
//{
   
//    public class BooksController : Controller
//    {
//        private readonly IGenreService _genreService;
//        public BookController(IGenreService genreService)
//        {
//            _genreService = genreService;
//        }
//        public IActionResult Add()
//        {
//            return View();
//        }

//        [HttpPost]
//        public IActionResult Add(Genre model)
//        {
//            if (!ModelState.IsValid)
//                return View(model);
//            var result = _genreService.Add(model);
//            if (result)
//            {
//                TempData["msg"] = "Added Successfully";
//                return RedirectToAction(nameof(Add));
//            }
//            else
//            {
//                TempData["msg"] = "Error on server side";
//                return View(model);
//            }
//        }
//        //
//        //[Authorize(Roles = "admin")]
//        public IActionResult Edit(int id)
//        {
//            var data = _genreService.GetById(id);
//            return View(data);
//        }

//        [HttpPost]
//        public IActionResult Update(Genre model)
//        {
//            if (!ModelState.IsValid)
//                return View(model);
//            var result = _genreService.Update(model);
//            if (result)
//            {
//                TempData["msg"] = "Added Successfully";
//                return RedirectToAction(nameof(BookList));
//            }
//            else
//            {
//                TempData["msg"] = "Error on server side";
//                return View(model);
//            }
//        }

//        public IActionResult BookList()
//        {
//            var data = this._genreService.List().ToList();
//            return View(data);
//        }

//        public IActionResult Delete(int id)
//        {
//            var result = _genreService.Delete(id);
//            return RedirectToAction(nameof(BookList));
//        }



//    }
//    //    private readonly DatabaseContext _context;

//    //    public BooksController(DatabaseContext context)
//    //    {
//    //        _context = context;
//    //    }

//    //    // GET: Books
//    //    public async Task<IActionResult> Index()
//    //    {
//    //          return View(await _context.Book.ToListAsync());
//    //    }

//    //    // GET: Books/Details/5
//    //    public async Task<IActionResult> Details(int? id)
//    //    {
//    //        if (id == null || _context.Book == null)
//    //        {
//    //            return NotFound();
//    //        }

//    //        var book = await _context.Book
//    //            .FirstOrDefaultAsync(m => m.Id == id);
//    //        if (book == null)
//    //        {
//    //            return NotFound();
//    //        }

//    //        return View(book);
//    //    }

//    //    // GET: Books/Create
//    //    public IActionResult Create()
//    //    {
//    //        return View();
//    //    }

//    //    // POST: Books/Create
//    //    // To protect from overposting attacks, enable the specific properties you want to bind to.
//    //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//    //    [HttpPost]
//    //    [ValidateAntiForgeryToken]
//    //    public async Task<IActionResult> Create([Bind("Id,Tytul,Rezyser,Opis")] Book book)
//    //    {
//    //        if (ModelState.IsValid)
//    //        {
//    //            _context.Add(book);
//    //            await _context.SaveChangesAsync();
//    //            return RedirectToAction(nameof(Index));
//    //        }
//    //        return View(book);
//    //    }

//    //    // GET: Books/Edit/5
//    //    public async Task<IActionResult> Edit(int? id)
//    //    {
//    //        if (id == null || _context.Book == null)
//    //        {
//    //            return NotFound();
//    //        }

//    //        var book = await _context.Book.FindAsync(id);
//    //        if (book == null)
//    //        {
//    //            return NotFound();
//    //        }
//    //        return View(book);
//    //    }

//    //    // POST: Books/Edit/5
//    //    // To protect from overposting attacks, enable the specific properties you want to bind to.
//    //    // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
//    //    [HttpPost]
//    //    [ValidateAntiForgeryToken]
//    //    public async Task<IActionResult> Edit(int id, [Bind("Id,Tytul,Rezyser,Opis")] Book book)
//    //    {
//    //        if (id != book.Id)
//    //        {
//    //            return NotFound();
//    //        }

//    //        if (ModelState.IsValid)
//    //        {
//    //            try
//    //            {
//    //                _context.Update(book);
//    //                await _context.SaveChangesAsync();
//    //            }
//    //            catch (DbUpdateConcurrencyException)
//    //            {
//    //                if (!BookExists(book.Id))
//    //                {
//    //                    return NotFound();
//    //                }
//    //                else
//    //                {
//    //                    throw;
//    //                }
//    //            }
//    //            return RedirectToAction(nameof(Index));
//    //        }
//    //        return View(book);
//    //    }

//    //    // GET: Books/Delete/5
//    //    public async Task<IActionResult> Delete(int? id)
//    //    {
//    //        if (id == null || _context.Book == null)
//    //        {
//    //            return NotFound();
//    //        }

//    //        var book = await _context.Book
//    //            .FirstOrDefaultAsync(m => m.Id == id);
//    //        if (book == null)
//    //        {
//    //            return NotFound();
//    //        }

//    //        return View(book);
//    //    }

//    //    // POST: Books/Delete/5
//    //    [HttpPost, ActionName("Delete")]
//    //    [ValidateAntiForgeryToken]
//    //    public async Task<IActionResult> DeleteConfirmed(int id)
//    //    {
//    //        if (_context.Book == null)
//    //        {
//    //            return Problem("Entity set 'Datebaseontext.Book'  is null.");
//    //        }
//    //        var book = await _context.Book.FindAsync(id);
//    //        if (book != null)
//    //        {
//    //            _context.Book.Remove(book);
//    //        }

//    //        await _context.SaveChangesAsync();
//    //        return RedirectToAction(nameof(Index));
//    //    }

//    //    private bool BookExists(int id)
//    //    {
//    //      return _context.Book.Any(e => e.Id == id);
//    //    }

//}
