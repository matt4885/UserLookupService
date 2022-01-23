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
}
