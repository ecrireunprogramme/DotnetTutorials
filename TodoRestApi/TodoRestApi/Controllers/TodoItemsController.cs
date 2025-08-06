using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TodoRestApi.Dtos;
using TodoRestApi.Services;

namespace TodoRestApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoItemsController : ControllerBase
    {
        private readonly ITodoItemService _todoItemService;

        public TodoItemsController(ITodoItemService todoItemService)
        {
            _todoItemService = todoItemService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var todoItems = await _todoItemService.GetAllAsync();
            return Ok(todoItems);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateTodoItemDto createTodoItemDto)
        {
            if (ModelState.IsValid == false)
            {
                return BadRequest(ModelState);
            }

            var createdTodoItem = await _todoItemService.CreateAsync(createTodoItemDto);
            return Created($"/api/TodoItems/{createdTodoItem.Id}", createdTodoItem);
        }
    }
}
