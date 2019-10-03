using System;
using System.Collections.Generic;
using System.Linq;

namespace Client.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public virtual IQueryable<Product> Product { get; set; }
    }

}
