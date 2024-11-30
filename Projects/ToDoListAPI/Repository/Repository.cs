using ToDoListAPI.Models;
using Task = ToDoListAPI.Models.Task;

namespace ToDoListAPI.Repository
{
    public class Repository
    {
        ToDoListContext db;

        public Repository(ToDoListContext db)
        {
            this.db = db;
        }

        public void Add(Task task)
        {
            db.Tasks.Add(task);
            db.SaveChanges();
        }

        public void Update(Task task)
        {
            db.Tasks.Update(task);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var task = db.Tasks.Find(id);
            db.Tasks.Remove(task);
            db.SaveChanges();
        }

        public Task GetById(int id)
        {
            return db.Tasks.Find(id);
        }

        public List<Task> GetAllTasks()
        {
            return db.Tasks.ToList();
        }

        public List<Task> GetByPriority(Priority priority)
        {
            return db.Tasks.Where(t => t.Priority == priority).ToList();
        }

        public List<Task> GetByStatus(bool status)
        {
            return db.Tasks.Where(t => t.Status == status).ToList();
        }

        public List<Task> GetByDueDate(DateTime dueDate)
        {
            return db.Tasks.Where(t => t.DueDate == dueDate).ToList();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
