using System;
using System.Collections.Generic;


namespace Client.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        public virtual IEnumerable<Product> Product { get; set; }
    }

}
