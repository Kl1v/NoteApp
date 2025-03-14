using System.Linq.Expressions;

namespace Domain.Interface;

public interface IRepositoryAsync<TEntity> where TEntity : class
{
    Task<TEntity> CreateAsync(TEntity entity);
    
    Task<List<TEntity>> CreateRangeAsync(List<TEntity> entities);
    
    Task<TEntity> ReadAsync(int id);
    
    Task<List<TEntity>> ReadAsync(Expression<Func<TEntity, bool>> filter);
    
    Task<List<TEntity>> ReadAsync(int start, int count);
    
    Task<List<TEntity>> ReadAllAsync();
    
    Task UpdateAsync(TEntity entity);
    
    Task UpdateRangeAsync(List<TEntity> entities);
    
    Task DeleteAsync(TEntity entity);
    
    
    
}