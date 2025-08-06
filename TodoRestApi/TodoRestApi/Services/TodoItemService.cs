using System;
using Mapster;
using Microsoft.EntityFrameworkCore;
using TodoRestApi.Data;
using TodoRestApi.Data.Models;
using TodoRestApi.Dtos;

namespace TodoRestApi.Services;

public class TodoItemService : ITodoItemService
{
    private readonly AppDbContext _context;

    public TodoItemService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<TodoItemDto>> GetAllAsync()
    {
        var todoItems = await _context.TodoItems
            .AsNoTracking()
            .ProjectToType<TodoItemDto>()
            .ToListAsync();
            
        return todoItems;
    }

    // Implementation of CreateAsync method
    public async Task<CreatedTodoItemDto> CreateAsync(CreateTodoItemDto createTodoItemDto)
    {
        var todoItem = createTodoItemDto.Adapt<TodoItem>();

        _context.TodoItems.Add(todoItem);
        await _context.SaveChangesAsync();

        return todoItem.Adapt<CreatedTodoItemDto>();
    }
}
