using Microsoft.EntityFrameworkCore.ChangeTracking;
using TestSamble.Data;
using TestSamble.Models;

namespace TestSamble.Services
{
    public class BookService : IBookInterface
    {
        private readonly AppDbContext appDbContext;

        public BookService(AppDbContext appDbContext) 
        { 
         this.appDbContext = appDbContext;
        }

        public EntityEntry addBook(Book book)
        {
            var result= appDbContext.Books.Add(book);
            appDbContext.SaveChanges();
            return result;
        }

        public void deleteBook(int bookId)
        {
            var book = appDbContext.Books.Find(bookId);
            appDbContext.Books.Remove(book);
            appDbContext.SaveChanges();
        }

        public List<Book> getBooks()
        {
            var books  = appDbContext.Books.ToList();
            return books;
        }

        public void updateBook(int bookId, UpdateBook updateBook)
        {
            var book = appDbContext.Books.Find(bookId);
            if(updateBook.Title != null) 
            {
                book.Title = updateBook.Title;
                appDbContext.SaveChanges();
            }
        }
    }
}
