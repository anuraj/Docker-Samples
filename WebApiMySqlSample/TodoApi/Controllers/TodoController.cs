using TodoApi.Data;
using TodoApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TodoController : ControllerBase
{
    private readonly ILogger<TodoController> _logger;
    private readonly ApiDbContext _dbContext;

    public TodoController(ILogger<TodoController> logger, ApiDbContext dbContext)
    {
        _logger = logger;
        _dbContext = dbContext;
    }

    [HttpGet(Name = "GetTodos")]
    public IActionResult Get()
    {
        var todos = _dbContext.Todos.ToList();
        return Ok(todos);
    }

    [HttpPost(Name = "CreateTodo")]
    public IActionResult Create([FromBody] Todo todo)
    {
        _dbContext.Todos.Add(todo);
        _dbContext.SaveChanges();
        return Ok(todo);
    }
}