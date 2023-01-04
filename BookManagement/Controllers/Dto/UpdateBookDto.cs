namespace BookManagement.Controllers.Dto;
public record UpdateBookDto(Guid Id,
                            string Title,
                            string Author,
                            DateTime DateOfPublication);