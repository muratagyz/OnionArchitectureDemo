﻿using OnionArchitectureDemo.Domain.Common;

namespace OnionArchitectureDemo.Application.Interfaces.Repository;

public interface IGenericRepositoryAsync<T> where T : BaseEntity
{
    Task<List<T>> GetAllAsync();
    Task<T> GetByIdAsync(Guid Id);
    Task<T> AddAsync(T entity);
}