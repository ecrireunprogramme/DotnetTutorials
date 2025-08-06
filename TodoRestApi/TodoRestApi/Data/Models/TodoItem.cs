using System;
using System.ComponentModel.DataAnnotations;

namespace TodoRestApi.Data.Models;

public class TodoItem
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public required string Title { get; set; }

    [StringLength(500)]
    public string? Description { get; set; }
    
    public bool IsCompleted { get; set; } = false;
}
