using P2_MSM_TIDSM4A_U3.Data;
using P2_TIDSM4A_MSM_U3.Data.ViewModels;
using P2_MSM_TIDSM4A_U3.Data.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace P2_TIDSM4A_MSM_U3.Data.Models.Services
{
    public class BooksService
    {
        private AppDbContext _context;
        public BooksService(AppDbContext context)
        {
            _context = context;
        }
        //Metodo para agregar libros
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
        //Metodo para listar libros de la BD
        public List<Book> GetAllBks() => _context.Books.ToList();
        //Metodo para listar libro de la BD usando la id
        public Book GetBookById(int bookid) => _context.Books.FirstOrDefault(n => n.id == bookid);

        //Metodo para modificar libro de la BD
        public Book UpdateBookByID(int bookid, BookVM book ) 
        {
            var _book = _context.Books.FirstOrDefault(n => n.id == bookid);
            if (_book != null) 
            {
                _book.Titulo = book.Titulo;
                _book.Descripcion = book.Descripcion;
                _book.IsRead = book.IsRead;
                _book.DateRead = book.DateRead;
                _book.Rate = book.Rate;
                _book.Genero = book.Genero;
                _book.Autor = book.Autor;
                _book.CoverUrl = book.CoverUrl;

                _context.SaveChanges();
            }
            return _book;
        }

        public void DeleteBookById(int bookid) 
        {
            var _book = _context.Books.FirstOrDefault(n => n.id == bookid);
            if(_book != null) 
            {
                _context.Books.Remove(_book);
                _context.SaveChanges();
            }
        }

    }
}
