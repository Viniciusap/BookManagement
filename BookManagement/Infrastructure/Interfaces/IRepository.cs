using BookManagement.Models;

namespace BookManagement.Infrastructure.Interfaces
{
    public interface IBookRepository
    {
        bool Add(Book entity);
        Book Update(Book book);
        List<Book> GetAll();
    }
}
