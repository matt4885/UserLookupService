namespace UserLookupService.Data;

public class UserRepository : IUserRepository
{
    private readonly MainContext _dbContext;
    public UserRepository(MainContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Abstractions.User> AddAsync(Abstractions.User user, CancellationToken cancellationToken)
    {
        await _dbContext.Users.AddAsync(UserModelMapper.ToDatabase(user), cancellationToken);
        await _dbContext.SaveChangesAsync(cancellationToken);
        return user;
    }

    public async Task DeleteUserAsync(Guid id, CancellationToken cancellationToken)
    {
         _dbContext.Users.Remove(new User
        {
            Id = id
        });
        await _dbContext.SaveChangesAsync(cancellationToken);
    }

    public async Task<Abstractions.User> UpdateUserAsync(User user, CancellationToken cancellationToken)
    {
       await DeleteUserAsync(user.Id, cancellationToken);

       return await AddAsync(UserModelMapper.ToBusiness(user), cancellationToken);
    }
}


