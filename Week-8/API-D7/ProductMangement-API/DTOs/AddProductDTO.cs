namespace ProductMangement_API.DTOs
{
    public class AddProductDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public int CatalogId { get; set; }
        public IFormFile Photo { get; set; }
    }
}
