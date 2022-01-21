using UserLookupService.Abstractions;

namespace UserLookupService.Data;

public interface IUserRepository
{
    Task<User> AddAsync(UserLookupService.Abstractions.User user, CancellationToken cancellationToken);
}
