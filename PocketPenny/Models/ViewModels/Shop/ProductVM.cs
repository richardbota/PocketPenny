using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using PocketPenny.Models.Data;
using System.ComponentModel.DataAnnotations;

namespace PocketPenny.Models.ViewModels.Shop
{
    public class ProductVM
    {
        public ProductVM()
        {
            
        }

        public ProductVM(ProductDTO row)
        {
            Id = row.Id;
            Name = row.Name;
            Slug = row.Slug;
            Description = row.Description;
            Price = row.Price;
            CategoryName = row.CategoryName;
            CategoryId = row.CategoryId;
            ImageName = row.ImageName;
        }

        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Slug { get; set; }
        [Required]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string CategoryName { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public string ImageName { get; set; }

        public IEnumerable<SelectListItem> Categories { get; set; }
        public IEnumerable<string> GalleryImages { get; set; }
    }
}