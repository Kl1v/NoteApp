using Model.Configuration;

namespace Domain.Repositories;

public class NoteRepositoryAsyncAsync<TEntity> : ARepositoryAsyncAsync<TEntity> where TEntity : class
{
    public NoteRepositoryAsyncAsync(NoteContext context) : base(context)
    {
    }
}