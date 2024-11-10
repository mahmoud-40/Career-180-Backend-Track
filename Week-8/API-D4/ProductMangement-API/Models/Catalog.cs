﻿using System.ComponentModel.DataAnnotations;

namespace ProductMangement_API.Models
{
    public class Catalog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual List<Product> Products { get; set; } = new List<Product>();
    }
}
