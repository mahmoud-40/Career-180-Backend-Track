using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using ToDoListAPI.DTOs;
using ToDoListAPI.Models;
using Task = ToDoListAPI.Models.Task;
using ToDoListAPI.Repository;

namespace ToDoListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [SwaggerTag("CRUD Operations")]
    public class CrudController : ControllerBase
    {
        ToDoListContext db;
        private Repository.Repository repo;

        public CrudController(ToDoListContext db)
        {
            this.db = db;
            repo = new Repository.Repository(db);
        }

        [HttpPost]
        [SwaggerOperation(
            Summary = "Create a new task",
            Description = "Create a new task with the provided details"
        )]
        [SwaggerResponse(StatusCodes.Status200OK, "The task was created successfully")]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "The task could not be created")]
        public IActionResult Create([FromBody] AddTaskDTO taskDTO)
        {
            if (ModelState.IsValid)
            {
                Task task = new Task
                {
                    Title = taskDTO.Title,
                    Description = taskDTO.Description,
                    Status = taskDTO.Status,
                    CreatedDate = taskDTO.CreatedDate,
                    DueDate = taskDTO.DueDate,
                    Priority = taskDTO.Priority
                };

                repo.Add(task);

                return Ok(task);
            }

            return BadRequest();
        }

        [HttpPut("{id}")]
        [SwaggerOperation(
            Summary = "Edit a task",
            Description = "Edit a task with the provided details"
        )]
        [SwaggerResponse(StatusCodes.Status200OK, "The task was edited successfully")]
        [SwaggerResponse(StatusCodes.Status400BadRequest, "The task could not be edited")]
        public IActionResult Edit(int id, [FromBody] EditTaskDTO taskDTO)
        {
            if (ModelState.IsValid)
            {
                Task task = repo.GetById(id);

                if (task == null)
                {
                    return NotFound();
                }

                task.Title = taskDTO.Title;
                task.Description = taskDTO.Description;
                task.Status = taskDTO.Status;
                task.DueDate = taskDTO.DueDate;
                task.Priority = taskDTO.Priority;

                repo.Update(task);

                return Ok(task);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        [SwaggerOperation(
            Summary = "Delete a task",
            Description = "Delete a task with the provided ID"
        )]
        [SwaggerResponse(StatusCodes.Status200OK, "The task was deleted successfully")]
        [SwaggerResponse(StatusCodes.Status404NotFound, "The task was not found")]
        public IActionResult Delete(int id)
        {
            Task task = repo.GetById(id);

            if (task == null)
            {
                return NotFound();
            }

            repo.Delete(id);

            return Ok(task);
        }

        [HttpPut("{id}/priority")]
        [SwaggerOperation(
            Summary = "Update the priority of a task",
            Description = "Update the priority of a task with the provided ID"
        )]
        [SwaggerResponse(StatusCodes.Status200OK, "The priority was updated successfully")]
        [SwaggerResponse(StatusCodes.Status404NotFound, "The task was not found")]
        public IActionResult UpdatePriority(int id, [FromBody] Priority priority)
        {
            Task task = repo.GetById(id);

            if (task == null)
            {
                return NotFound();
            }

            task.Priority = priority;

            repo.Update(task);

            return Ok(task);
        }
    }
}
