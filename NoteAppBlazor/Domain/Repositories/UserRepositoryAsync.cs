using Model.Configuration;

namespace Domain.Repositories;

public class UserRepositoryAsync : ARepositoryAsync<User>
{
    public UserRepositoryAsync(PostContext context) : base(context)
    {
    }
}