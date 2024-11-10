﻿namespace ProductMangement_API.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Amount { get; set; }
        //public int CatalogId { get; set; }
        public string? CatalogName { get; set; }
    }
}
