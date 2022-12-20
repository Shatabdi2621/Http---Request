using Microsoft.AspNetCore.Mvc;
using ToDo.Model;

namespace ToDo.Controllers;

[ApiController]
[Route("[controller]")]

public class ToDoController : ControllerBase 
{
    static IList <Todo> todos = new List <Todo>()
    {
        new Todo {
            ID = 01,
            Deadline = "2022-12-31",
            Status = false,
            Task = "Hire Engineer",
            Details = "Hire a Azure Stack DevOps Engineer"
        },
        new Todo {
            ID = 02,
            Deadline = "2023-01-15",
            Status = false,
            Task = "C-Sharp",
            Details = "Learn C Sharp Coding"
        },
        new Todo {
            ID = 03,
            Deadline = "2023-01-30",
            Status = false,
            Task = "One-Minute Video Article",
            Details = "Create One-Minute Video 1000 words Article"
        }
    };

    [HttpGet]
    public IList <Todo> GetAllTodos() 
    {
        return todos;
    }

    [HttpGet("{id}")]
    public ActionResult<Todo> GetDetailsById(int id)
    {
        var todo = todos.FirstOrDefault(x => x.ID == id);
        if (!ModelState.IsValid)
        {
            return BadRequest("Incorrect Model");
        }
        else
        if (todo == null || id <= 0)
        {
            return NotFound("ID not found");
        } 
        else 
        {
            return todo;
        }
    }

    [HttpPost]
    public ActionResult<Todo> PostAddTodo(Todo model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest("Incorrect Model");
        }
        var todo = new Todo
        {
            ID = model.ID,
            Deadline = model.Deadline,
            Status= model.Status,
            Task = model.Task,
            Details = model.Details
        };
        todos.Add(todo);
        return Ok();
    }

    [HttpPut]
    public ActionResult<Todo> PutUpdateTodo(Todo model, int id)
    {
        var existingtodo = todos.FirstOrDefault(x => x.ID == id);
        if (!ModelState.IsValid)
        {
            return BadRequest("Incorrect Model");
        }
        else
        if (existingtodo == null)
        {
            return NotFound("Invalid ID");
        } 
        else 
        {
            existingtodo.ID = model.ID;
            existingtodo.Deadline = model.Deadline;
            existingtodo.Status= model.Status;
            existingtodo.Task = model.Task;
            existingtodo.Details = model.Details;
        }
        return Ok();
    }

    [HttpDelete]
    public ActionResult<Todo> DeleteDetailByID(int id, Todo model)
    {
        var checktodo = todos.FirstOrDefault(x => x.ID == id);
        if (!ModelState.IsValid)
        {
            return BadRequest("Incorrect Model");
        }
        else
        if (checktodo == null || id <= 0)
        {
            return NotFound("Invalid ID");
        } 
        else 
        {
            todos.Remove(checktodo);
        }
        return Ok();
    }
}