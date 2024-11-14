using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductMangement_API.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; } // by default auto increment
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "money")]
        public decimal Price { get; set; }
        public int Amount { get; set; }
        public string Photo { get; set; }
        [ForeignKey("catalog")]
        public int CatalogId { get; set; }
        public virtual Catalog? catalog { get; set; }
    }
}
