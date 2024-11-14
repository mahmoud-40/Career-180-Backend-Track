using ProductMangement_API.Models;

namespace ProductMangement_API.Repository
{
    public class GenericRepository<T> where T : class
    {
        StoreContext db;
        public GenericRepository(StoreContext context)
        {
            db = context;
        }

        public List<T> GetAll()
        {
            return db.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return db.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
            db.Set<T>().Add(entity);
        }

        public void Update(T entity)
        {
            db.Set<T>().Update(entity);
        }

        public void Delete(int id)
        {
            T entity = db.Set<T>().Find(id);
            db.Set<T>().Remove(entity);
        }
    }
}
