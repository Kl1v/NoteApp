using System.Linq.Expressions;
using Domain.Interface;
using Microsoft.EntityFrameworkCore;
using Model.Configuration;

namespace Domain.Repositories;

public abstract class ARepositoryAsyncAsync<TEntity> : IRepositoryAsync<TEntity> where TEntity : class
{
    protected NoteContext _context;
    protected DbSet<TEntity> _table;

    public ARepositoryAsyncAsync(NoteContext context)
    {
        _context = context;
        _table = _context.Set<TEntity>();
    }
    
    public async Task<TEntity> CreateAsync(TEntity list)
    {
        _table.Add(list);
        await _context.SaveChangesAsync();
        return list;
    }

    public async Task<List<TEntity>> CreateRangeAsync(List<TEntity> entities)
    {
        _table.AddRange(entities);
        await _context.SaveChangesAsync();
        return entities;
    }

    public async Task<TEntity> ReadAsync(int id)
    {
        return await _table.FindAsync(id);
    }

    public async Task<List<TEntity>> ReadAsync(Expression<Func<TEntity, bool>> filter)
    {
        return await _table.Where(filter).ToListAsync();
    }

    public async Task<List<TEntity>> ReadAsync(int start, int count)
    {
        return await _table.Skip(start).Take(count).ToListAsync();
    }

    public async Task<List<TEntity>> ReadAllAsync()
    {
        return await _table.ToListAsync();
    }

    public async Task UpdateAsync(TEntity entity)
    {
        _context.ChangeTracker.Clear();
        _table.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateRangeAsync(List<TEntity> entities)
    {
        _table.UpdateRange(entities);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(TEntity entity)
    {
        _table.Remove(entity);
        await _context.SaveChangesAsync();
    }
}