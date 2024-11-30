using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListAPI.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        [Column(TypeName = "Date")]
        public DateTime CreatedDate { get; set; }
        [Column(TypeName = "Date")]
        public DateTime DueDate { get; set; }
        public Priority Priority { get; set; }
    }
    public enum Priority
    {
        Low,
        Medium,
        High
    }
}
