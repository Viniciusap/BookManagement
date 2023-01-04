using BookManagement.Infrastructure.Interfaces;
using BookManagement.Models;

namespace BookManagement.Infrastructure
{
    public class BookRepository : IBookRepository
    {
        private List<Book> books;

        public BookRepository()
        {
            books = new List<Book>();
        }

        public bool Add(Book entity)
        {
            books.Add(entity);
            return true;
        }

        public List<Book> GetAll()
        {
            return books.ToList();
        }

        public Book Update(Book bookUpdated)
        {
            var bookFind = books.FirstOrDefault(x => x.Id == bookUpdated.Id);
            if (bookFind != null) 
            {
                bookFind.Author = bookUpdated.Author;
                bookFind.Title = bookUpdated.Title;
                bookFind.DateOfPublication = bookUpdated.DateOfPublication;
            }

            return bookFind;
        }
    }
}
