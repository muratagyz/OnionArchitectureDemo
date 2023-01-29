using OnionArchitectureDemo.Domain.Entities;

namespace OnionArchitectureDemo.Application.Interfaces.Repository;

public interface IProductRepository : IGenericRepositoryAsync<Product>
{
}