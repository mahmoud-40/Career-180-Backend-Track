using Microsoft.EntityFrameworkCore;

namespace ToDoListAPI.Models
{
    public class ToDoListContext:DbContext
    {
        public ToDoListContext(DbContextOptions<ToDoListContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Task> Tasks { get; set; }
    }
}
