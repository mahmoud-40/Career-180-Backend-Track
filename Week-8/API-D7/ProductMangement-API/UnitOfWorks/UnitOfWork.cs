using ProductMangement_API.DTOs;
using ProductMangement_API.Models;
using ProductMangement_API.Repository;

namespace ProductMangement_API.UnitOfWorks
{
    public class UnitOfWork
    {
        StoreContext db;
        public UnitOfWork(StoreContext context)
        {
            db = context;
        }

        GenericRepository<Product> productRepo;
        public GenericRepository<Product> ProductRepo
        {
            get
            {
                if (productRepo == null)
                    productRepo = new GenericRepository<Product>(db);
                return productRepo;
            }
        }

        GenericRepository<Catalog> catalogRepo;
        public GenericRepository<Catalog> CatalogRepo
        {
            get
            {
                if (catalogRepo == null)
                    catalogRepo = new GenericRepository<Catalog>(db);
                return catalogRepo;
            }
        }

        public List<ProductDTO> GetAllProducts()
        {
            List<Product> products = ProductRepo.GetAll();

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
                    CatalogName = CatalogRepo.GetById(product.CatalogId).Name
                });
            }

            return productsDTO;
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
