using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductMangement_API.DTOs;
using ProductMangement_API.Models;

namespace ProductMangement_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        StoreContext db;
        public ProductsController(StoreContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            List<Product> products = db.Products.ToList();

            List<ProductDTO> productsDTO = new List<ProductDTO>();

            foreach (Product product in products)
            {
                productsDTO.Add(new ProductDTO
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    Amount = product.Amount,
                    CatalogName = db.Catalogs.Where(n => n.Id == product.CatalogId).Select(n => n.Name).FirstOrDefault()
                });
            }

            return Ok(productsDTO);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {

            Product product = db.Products.Find(id);

            if (product == null)
            {
                return NotFound();
            }

            ProductDTO productDto = new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Amount = product.Amount,
                CatalogName = db.Catalogs.Where(n => n.Id == product.CatalogId).Select(n => n.Name).FirstOrDefault()
            };

            return Ok(productDto);
        }

        [HttpGet("catalog/{catalogId}")]
        public IActionResult GetByCatalog(int catalogId)
        {
            List<Product> products = db.Products.Where(x => x.CatalogId == catalogId).ToList();

            List<ProductDTO> productsDTO = new List<ProductDTO>();

            foreach (Product product in products)
            {
                productsDTO.Add(new ProductDTO
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    Amount = product.Amount,
                    CatalogName = db.Catalogs.Where(n => n.Id == product.CatalogId).Select(n => n.Name).FirstOrDefault()
                });
            }

            return Ok(productsDTO);
        }

        [HttpGet("price/{price}")]
        public IActionResult GetByPrice(decimal price)
        {
            List<Product> products = db.Products.Where(x => x.Price == price).ToList();

            List<ProductDTO> productsDTO = new List<ProductDTO>();

            foreach (Product product in products)
            {
                productsDTO.Add(new ProductDTO
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    Amount = product.Amount,
                    CatalogName = db.Catalogs.Where(n => n.Id == product.CatalogId).Select(n => n.Name).FirstOrDefault()
                });
            }

            return Ok(productsDTO);
        }

        [HttpPost]
        public IActionResult Add(Product product)
        {
            if(product == null) 
                return BadRequest();

            db.Products.Add(product);
            db.SaveChanges();

            ProductDTO productDTO = new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Amount = product.Amount,
                CatalogName = db.Catalogs.Where(n => n.Id == product.CatalogId).Select( n => n.Name).FirstOrDefault()
            };

            return CreatedAtAction("GetById", new { id = product.Id }, productDTO);
        }

        [HttpPut]
        public IActionResult Update(Product product)
        {
            if (product == null)
                return BadRequest();

            if(ModelState.IsValid)
            {
                db.Update(product);
                db.SaveChanges();

                ProductDTO productDTO = new ProductDTO 
                {
                    Id = product.Id,
                    Name = product.Name,
                    Description = product.Description,
                    Price = product.Price,
                    Amount = product.Amount,
                    CatalogName = db.Catalogs.Where(n => n.Id == product.CatalogId).Select(n => n.Name).FirstOrDefault()
                };

                return Ok(productDTO);
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Product product = db.Products.FirstOrDefault(x => x.Id == id);

            if (product == null)
                return NotFound();

            db.Products.Remove(product);
            db.SaveChanges();

            List<ProductDTO> productsDTO = new List<ProductDTO>();

            foreach (Product p in db.Products.ToList())
            {
                productsDTO.Add(new ProductDTO
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Price = p.Price,
                    Amount = p.Amount,
                    CatalogName = db.Catalogs.Where(n => n.Id == p.CatalogId).Select(n => n.Name).FirstOrDefault()
                });
            }

            return Ok(productsDTO);
        }
    }
}
