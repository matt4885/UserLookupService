using UserLookupService.Abstractions;

namespace UserLookupService.Data;

public interface IUserRepository
{
    Task<Abstractions.User> AddAsync(Abstractions.User user, CancellationToken cancellationToken);
}
