using Model.Configuration;

namespace Domain.Repositories;

public class UserRepositoryAsync : ARepositoryAsync<User>
{
    public UserRepositoryAsync(PostContext context) : base(context) { }
    public async Task<User> FindByEmailAsync(string email)
    {
        return base._table.FirstOrDefault(x => x.Email == email);
    }
    public async Task<User> FindByUsernameAsync(string username)
    {
        return base._table.FirstOrDefault(x => x.Username == username);
    }
}