using System;
using Microsoft.AspNetCore.Http.HttpResults;
using TodoRestApi.Dtos;

namespace TodoRestApi.Services;

public interface ITodoItemService
{
    Task<IEnumerable<TodoItemDto>> GetAllAsync();
    Task<CreatedTodoItemDto> CreateAsync(CreateTodoItemDto createTodoItemDto);
}
