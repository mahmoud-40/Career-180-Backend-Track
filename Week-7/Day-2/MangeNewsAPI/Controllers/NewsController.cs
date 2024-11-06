using MangeNewsAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MangeNewsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        List<New> news = new List<New>
        {
            new New { Id = 1, Title = "Win", Description = "Barcelona wins!", Author = "Mahmoud" },
            new New { Id = 2, Title = "Lose", Description = "Real Madrid lose!", Author = "Ahmed" },
            new New { Id = 3, Title = "Draw", Description = "No winner", Author = "Ali" }
        };

        [HttpGet]
        public List<New> GetAll() // url : /api/news
        {
            return news;
        }

        [HttpGet]
        [Route("{id}")]
        public New GetById(int id) // url : /api/news/1
        {
            return news.FirstOrDefault(n => n.Id == id);
        }

        //GetByAuthor
        [HttpGet]
        [Route("author/{author}")]
        public List<New> GetByAuthor(string author) // url : /api/news/author/Mahmoud
        {
            return news.Where(n => n.Author == author).ToList();
        }

        // GetByTitle

        [HttpGet]
        [Route("title/{title}")]
        public New GetByTitle(string title) // url : /api/news/title/Win
        {
            return news.FirstOrDefault(n => n.Title == title);
        }

        // add
        [HttpPost]
        public IActionResult Add(New newNew) 
        {
            if(newNew == null)
            {
                return BadRequest();
            }

            news.Add(newNew);

            return Created();
        }


        // edit
        [HttpPut("{id}")]
        public IActionResult Edit(int id, New newNew)
        {
            if(newNew == null || newNew.Id != id)
            {
                return BadRequest();
            }

            var existingNew = news.FirstOrDefault(n => n.Id == id);

            if(existingNew == null)
            {
                return NotFound();
            }

            existingNew.Title = newNew.Title;
            existingNew.Description = newNew.Description;
            existingNew.Author = newNew.Author;

            return NoContent();
        }

        // delete
        [HttpDelete("id")]
        public IActionResult Delete(int id)  
        {
            var existingNew = news.FirstOrDefault(n => n.Id == id);

            if(existingNew == null)
            {
                return NotFound();
            }

            news.Remove(existingNew);

            return Ok(existingNew);
        }
    }
}
