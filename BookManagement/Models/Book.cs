using System.ComponentModel.DataAnnotations;

namespace BookManagement.Models
{
    public class Book
    {
        public Book()
        {
        }

        public Book(string title, string author, DateTime dateOfPublication)
        {
            Id = Guid.NewGuid();
            Title = title;
            Author = author;
            DateOfPublication = dateOfPublication;
        }

        /// <summary>
        /// For update pourpose
        /// </summary>
        /// <param name="id"></param>
        /// <param name="title"></param>
        /// <param name="author"></param>
        /// <param name="dateOfPublication"></param>
        public Book(Guid id, string title, string author, DateTime dateOfPublication)
        {
            Id = id;
            Title = title;
            Author = author;
            DateOfPublication = dateOfPublication;
        }

        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        public DateTime DateOfPublication { get; set; }
    }
}
