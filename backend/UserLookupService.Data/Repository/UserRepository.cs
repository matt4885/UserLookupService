namespace UserLookupService.Data;

public class UserRepository : IUserRepository
{
    public Task<Abstractions.User> AddAsync(Abstractions.User user, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    Task<User> IUserRepository.AddAsync(Abstractions.User user, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
