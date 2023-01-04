namespace BookManagement.Controllers.Dto;
public record AddBookDto(Guid Id,
                         string Title,
                         string Author,
                         DateTime DateOfPublication);