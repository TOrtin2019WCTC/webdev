using System;
using System.Linq;
using Client.wwwroot.Views.Shared.Models;

namespace Client.Models
{
    public interface INorthwindRepository
    {
        IQueryable<Category> Categories { get; }
        IQueryable<Product> Products { get; }
    }
}
