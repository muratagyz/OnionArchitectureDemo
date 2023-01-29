using Microsoft.EntityFrameworkCore;
using OnionArchitectureDemo.Application.Interfaces.Repository;
using OnionArchitectureDemo.Domain.Common;
using OnionArchitectureDemo.Persistence.Context;

namespace OnionArchitectureDemo.Persistence.Repositories;

public class GenericRepositoryAsync<T> : IGenericRepositoryAsync<T> where T : BaseEntity
{
    private readonly ApplicationDbContext _context;
    private readonly DbSet<T> _dbSet;
    public GenericRepositoryAsync(ApplicationDbContext applicationDbContext)
    {
        _context = applicationDbContext;
        _dbSet = _context.Set<T>();
    }

    public async Task<List<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T> GetByIdAsync(Guid Id)
    {
        return await _dbSet.FindAsync(Id);
    }

    public async Task<T> AddAsync(T entity)
    {
        await _dbSet.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
}