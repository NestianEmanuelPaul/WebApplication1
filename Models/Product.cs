using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public decimal? Price { get; set; }
        public string? Title { get; set; }
    }
}
