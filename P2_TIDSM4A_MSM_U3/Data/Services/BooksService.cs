using P2_MSM_TIDSM4A_U3.Data;
using P2_TIDSM4A_MSM_U3.Data.ViewModels;
using P2_MSM_TIDSM4A_U3.Data.Models;
using System;
using System.Linq;
using System.Collections.Generic;

namespace P2_TIDSM4A_MSM_U3.Data.Models.Services
{
    public class BooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context = context;
        }

        public void AddBook(BookVM book)
        {
            var _book = new Book()
            {
                Titulo = book.Titulo,
                Descripcion = book.Descripcion,
                IsRead = book.IsRead,
                DateRead = book.DateRead,
                Rate = book.Rate,
                Genero = book.Genero,
                Autor = book.Autor,
                CoverUrl = book.CoverUrl,
                DateAdded = DateTime.Now
            };
            _context.Books.Add(_book);
            _context.SaveChanges();
        }
        public List<Book> GetAllBks() => _context.Books.ToList();
        public Book GetBookById(int bookid) => _context.Books.FirstOrDefault(n => n.id == bookid);

    }
}
