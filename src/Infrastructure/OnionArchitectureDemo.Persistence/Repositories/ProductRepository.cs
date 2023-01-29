using OnionArchitectureDemo.Application.Interfaces.Repository;
using OnionArchitectureDemo.Domain.Entities;
using OnionArchitectureDemo.Persistence.Context;

namespace OnionArchitectureDemo.Persistence.Repositories;

public class ProductRepository : GenericRepositoryAsync<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
    {
    }
}