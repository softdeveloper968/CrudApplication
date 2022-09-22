using System;
using System.Collections.Generic;

#nullable disable

namespace CrudApplication.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
    }
}
