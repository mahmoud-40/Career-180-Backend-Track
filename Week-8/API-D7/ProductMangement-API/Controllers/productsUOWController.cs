using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductMangement_API.DTOs;
using ProductMangement_API.Models;
using ProductMangement_API.UnitOfWorks;
using Swashbuckle.AspNetCore.Annotations;

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
        [SwaggerOperation(Summary = "Get all products", Description = "Get all products from the database")]
        [SwaggerResponse(200, "You get all products", typeof(ProductDTO))]
        [SwaggerResponse(400, "Problem occured", typeof(ProductDTO))]
        public IActionResult GetAll()
        {
            return Ok(unit.GetAllProducts());
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Get product by id", Description = "Get product by id from the database")]
        [SwaggerResponse(200, "You get product by id", typeof(ProductDTO))]
        [SwaggerResponse(400, "Invalid Id", typeof(ProductDTO))]
        public IActionResult GetById(int id)
        {
            return Ok(unit.ProductRepo.GetById(id));
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Add product", Description = "Add product to the database")]
        [SwaggerResponse(201, "Product added", typeof(ProductDTO))]
        [SwaggerResponse(400, "Problem occured", typeof(ProductDTO))]
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
        [SwaggerOperation(Summary = "Update product", Description = "Update product in the database")]
        [SwaggerResponse(200, "Product updated", typeof(ProductDTO))]
        [SwaggerResponse(400, "Problem occured", typeof(ProductDTO))]
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
        [SwaggerOperation(Summary = "Delete product", Description = "Delete product from the database")]
        [SwaggerResponse(200, "Product deleted", typeof(ProductDTO))]
        [SwaggerResponse(400, "Problem occured", typeof(ProductDTO))]
        public IActionResult Delete(int id) {
            unit.ProductRepo.Delete(id);
            unit.Save();
            return Ok();
        }
    }
}
