using MangeCources_API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MangeCources_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        static List<Course> courses = new List<Course>
        {
            new Course { Id = 1, Name = "C#", Duration = 30, Status = true },
            new Course { Id = 2, Name = "ASP.NET Core", Duration = 40, Status = true },
            new Course { Id = 3, Name = "SQL", Duration = 20, Status = false }
        };

        [HttpGet]
        public List<Course> GetAll()
        {
            return courses;
        }
        [HttpGet]
        [Route("{id}")]
        public Course GetById(int id)
        {
            return courses.FirstOrDefault(c => c.Id == id);
        }
    }
}
