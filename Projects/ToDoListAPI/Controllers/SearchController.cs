using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using ToDoListAPI.Models;

namespace ToDoListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [SwaggerTag("Search")]
    public class SearchController : ControllerBase
    {
        ToDoListContext db;
        private Repository.Repository repo;

        public SearchController(ToDoListContext db)
        {
            this.db = db;
            repo = new Repository.Repository(db);
        }

        [HttpGet]
        [SwaggerOperation(
            Summary = "Get all tasks",
            Description = "Get all tasks in the database"
        )]
        [SwaggerResponse(StatusCodes.Status200OK, "The tasks were retrieved successfully")]
        public IActionResult GetAllTasks()
        {
            return Ok(repo.GetAllTasks());
        }

        [HttpGet("{id}")]
        [SwaggerOperation(
            Summary = "Get a task by ID",
            Description = "Get a task by its ID"
        )]
        [SwaggerResponse(StatusCodes.Status200OK, "The task was retrieved successfully")]
        public IActionResult GetById(int id)
        {
            return Ok(repo.GetById(id));
        }

        [HttpGet("tasks/priority")]
        [SwaggerOperation(
            Summary = "Get tasks by priority",
            Description = "Get tasks by their priority"
        )]
        [SwaggerResponse(StatusCodes.Status200OK, "The tasks were retrieved successfully")]
        public IActionResult GetByPriority(Priority priority)
        {
            var tasks = repo.GetByPriority(priority);

            return Ok(tasks);
        }

        [HttpGet("tasks/status")]
        [SwaggerOperation(
            Summary = "Get tasks by status",
            Description = "Get tasks by their status"
        )]
        [SwaggerResponse(StatusCodes.Status200OK, "The tasks were retrieved successfully")]
        public IActionResult GetByStatus(bool completed)
        {
            var tasks = repo.GetByStatus(completed);
            return Ok(tasks);
        }

        [HttpGet("tasks")]
        [SwaggerOperation(
            Summary = "Get tasks by due date",
            Description = "Get tasks by their due date"
        )]
        [SwaggerResponse(StatusCodes.Status200OK, "The tasks were retrieved successfully")]
        public IActionResult GetByDueDate(DateTime dueDate)
        {
            var tasks = repo.GetByDueDate(dueDate);
            return Ok(tasks);
        }
    }
}
