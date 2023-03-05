using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureDemo.Application.Interfaces.Repository;
using OnionArchitectureDemo.Persistence.Context;
using OnionArchitectureDemo.Persistence.Repositories;

namespace OnionArchitectureDemo.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("memoryDb"));
        serviceCollection.AddTransient<IProductRepository, ProductRepository>();
    }
}