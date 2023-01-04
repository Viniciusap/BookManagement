using BookManagement.Controllers.Dto;
using BookManagement.Infrastructure.Interfaces;
using BookManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace BookManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BooksController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }       

        /// <summary>
        /// Add a new book to the library
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult AddBook(AddBookDto addBookDto)
        {
            if (addBookDto.DateOfPublication < DateTime.Now)
            {
                return Created("test", _bookRepository.Add(new Book(addBookDto.Title,
                                                                    addBookDto.Author,
                                                                    addBookDto.DateOfPublication)));
            }
            return BadRequest("Date of publication must be in the past");
        }

        /// <summary>
        /// Update an existing book in the library using its Id
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public IActionResult UpdateBook(UpdateBookDto updateBookDto)
        {
            if (updateBookDto.DateOfPublication < DateTime.Now)
            {
                return Ok(_bookRepository.Update(new Book(updateBookDto.Id, 
                                                          updateBookDto.Title,
                                                          updateBookDto.Author,
                                                          updateBookDto.DateOfPublication)));
            }
            return BadRequest("Date of publication must be in the past");
        }

        /// <summary>
        /// Get all books in the Library
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(_bookRepository.GetAll());
        }
    }
}