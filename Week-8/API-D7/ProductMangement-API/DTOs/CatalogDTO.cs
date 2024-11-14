using ProductMangement_API.Models;

namespace ProductMangement_API.DTOs
{
    public class CatalogDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Products { get; set; }
    }
}
