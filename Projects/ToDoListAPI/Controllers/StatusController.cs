using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using ToDoListAPI.Models;
using ToDoListAPI.Repository;
using Task = ToDoListAPI.Models.Task;

namespace ToDoListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [SwaggerTag("Status")]
    public class StatusController : ControllerBase
    {
        ToDoListContext db;
        Repository.Repository repo;

        public StatusController(ToDoListContext db)
        {
            this.db = db;
            repo = new Repository.Repository(db);
        }

        [HttpPut("{id}/complete")]
        [SwaggerOperation(
            Summary = "Complete a task",
            Description = "Mark a task as completed"
        )]
        [SwaggerResponse(StatusCodes.Status200OK, "The task was marked as completed")]
        [SwaggerResponse(StatusCodes.Status404NotFound, "The task could not be found")]
        public IActionResult CompleteTask(int id)
        {
            Task task = repo.GetById(id);

            if (task == null)
            {
                return NotFound();
            }

            task.Status = true;

            repo.Update(task);

            return Ok(task);
        }

        [HttpPut("{id}/incomplete")]
        [SwaggerOperation(
            Summary = "Incomplete a task",
            Description = "Mark a task as incomplete"
        )]
        [SwaggerResponse(StatusCodes.Status200OK, "The task was marked as incomplete")]
        [SwaggerResponse(StatusCodes.Status404NotFound, "The task could not be found")]
        public IActionResult IncompleteTask(int id)
        {
            Task task = repo.GetById(id);

            if (task == null)
            {
                return NotFound();
            }

            task.Status = false;

            repo.Update(task);

            return Ok(task);
        }
    }
}
