namespace CampusEats.Api.Dtos;

// output shape — public contract එක
public record MenuItemDto(
    int Id, string Name, decimal Price,
    string Category, bool Available);