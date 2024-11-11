using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductMangement_API.DTOs;
using ProductMangement_API.Models;
using ProductMangement_API.UnitOfWorks;

namespace ProductMangement_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class productsUOWController : ControllerBase
    {
        private UnitOfWork unit;

        public productsUOWController(UnitOfWork unit)
        {
            this.unit = unit;
        }
        
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(unit.GetAllProducts());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(unit.ProductRepo.GetById(id));
        }

        [HttpPost]
        public IActionResult Add([FromForm] AddProductDTO product) 
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "Uploads/");
            string photo = Path.Combine(path, product.Photo.FileName); // Final Path
            FileStream str = new FileStream(photo, FileMode.Create);
            product.Photo.CopyTo(str); 

            Product p = new Product
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Amount = product.Amount,
                CatalogId = product.CatalogId,
                Photo = photo // save path to db
            };

            unit.ProductRepo.Add(p);
            unit.Save();

            return CreatedAtAction("GetById", new { id = p.Id }, p); 
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, AddProductDTO product)
        {
            Product newProduct = new Product
            {
                Id = id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Amount = product.Amount,
                CatalogId = product.CatalogId
            };

            unit.ProductRepo.Update(newProduct);
            unit.Save();
            return Ok(newProduct);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) {
            unit.ProductRepo.Delete(id);
            unit.Save();
            return Ok();
        }
    }
}
