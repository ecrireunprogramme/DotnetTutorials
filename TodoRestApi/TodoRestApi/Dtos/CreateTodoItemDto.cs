using System;
using System.ComponentModel.DataAnnotations;

namespace TodoRestApi.Dtos;

public class CreateTodoItemDto
{
    [Required]
    [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
    public string Title { get; set; } = string.Empty;

    [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
    public string? Description { get; set; }
}
