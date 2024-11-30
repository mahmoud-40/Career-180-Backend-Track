using ToDoListAPI.Models;

namespace ToDoListAPI.DTOs
{
    public class EditTaskDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; }
    }
}
