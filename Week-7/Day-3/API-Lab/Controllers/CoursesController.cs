using API_Lab.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Lab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly APID3Context db;

        public CoursesController(APID3Context context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult get()
        {
            var courses = db.Courses.ToList();
            if (courses.Count == 0)
            {
                return NotFound();
            }
            return Ok(courses);
        }

        [HttpGet("{id}")]
        public IActionResult getById(int id)
        {
            var course = db.Courses.Find(id);
            if (course == null)
            {
                return NotFound();
            }
            return Ok(course);
        }

        [HttpGet("name/{name}")]
        public IActionResult getByName(string name)
        {
            var course = db.Courses.FirstOrDefault(c => c.CourseName == name);
            if (course == null)
            {
                return NotFound();
            }
            return Ok(course);
        }

        [HttpPost]
        public IActionResult post(Course course) // add
        {
            if (course == null)
            {
                return BadRequest();
            }
            
            if(ModelState.IsValid)
            {
                db.Courses.Add(course);
                db.SaveChanges();
                return CreatedAtAction("getById", new { id = course.Id }, course);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public IActionResult put(int id, Course course) // Edit
        {
            if (id != course.Id)
            {
                return BadRequest();
            }
            
            if(ModelState.IsValid)
            {
                db.Entry(course).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
                return NoContent();
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult deleteCourse(int id)
        {
            var course = db.Courses.Find(id);
            if (course == null)
            {
                return NotFound();
            }
            db.Courses.Remove(course);
            db.SaveChanges();
            return Ok(db.Courses.ToList());
        }
    }
}
