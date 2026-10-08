using System.ComponentModel.DataAnnotations;

namespace CampusEats.Api.Dtos;

// input shape — Id නෑ, server එකෙන් assign කරන්නේ
public record CreateMenuItemDto(
    [Required, StringLength(80)] string Name,
    [Range(0, 100000)] decimal Price,
    [Required, StringLength(40)] string Category);