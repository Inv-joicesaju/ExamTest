using Microsoft.EntityFrameworkCore.ChangeTracking;
using TestSamble.Models;

namespace TestSamble.Services
{
    public interface IBookInterface
    {
        public EntityEntry addBook(Book book);
        public List<Book> getBooks();
        public void updateBook(int bookId,UpdateBook updateBook);
        public void deleteBook(int bookId);
    }
}
