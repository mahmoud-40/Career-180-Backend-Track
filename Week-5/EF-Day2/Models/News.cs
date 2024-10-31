using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Day2.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [MaxLength(200)]
        public string Brief { get; set; }
        [MaxLength(500)]
        public string Desc { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public virtual int CatalogId { get; set; }
        public virtual Author Author { get; set; } = new Author();

        public override string ToString()
        {
            return $"Id: {Id}\n Title: {Title}\n Brief: {Brief}\n Desc: {Desc}\n Date: {Date}\n CatalogId: {CatalogId}\n";
        }
    }
}
