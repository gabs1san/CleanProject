using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchMvc.Domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public int Name { get; set; }

        public ICollection<Product> Products { get; set; }

    }
}
