using CleanArchMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetCategories();
        Task<Product> GetById(int? id);
        Task<Product> GetProductAsync(int? id);

        Task<Product> Create(Category category);
        Task<Product> Update(Category category);
        Task<Product> Remove(Category category);
    }
}

