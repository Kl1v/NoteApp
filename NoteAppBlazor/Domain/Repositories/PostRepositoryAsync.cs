using Model.Configuration;

namespace Domain.Repositories;

public class PostRepositoryAsync : ARepositoryAsync<Post>
{
    public PostRepositoryAsync(PostContext context) : base(context)
    {
    }
}