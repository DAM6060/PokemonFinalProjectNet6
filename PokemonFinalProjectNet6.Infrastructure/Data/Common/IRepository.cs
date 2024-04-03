﻿namespace PokemonFinalProjectNet6.Infrastructure.Data.Common;

public interface IRepository
{
    IQueryable<T> All<T>() where T : class;

    IQueryable<T> AllAsReadOnly<T>() where T : class;

    Task AddASync<T>(T entity) where T : class;

    Task<int> SaveChangesAsync();

    Task<T?> GetByIdAsync<T>(object id) where T : class;

    Task DeleteAsync<T>(object id) where T : class;
}
