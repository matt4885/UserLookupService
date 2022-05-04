using UserLookupService.Abstractions;

namespace UserLookupService.Data;

public interface IUserRepository
{
    Task<Abstractions.User> AddAsync(Abstractions.User user, CancellationToken cancellationToken);
    Task DeleteUserAsync(Guid id, CancellationToken cancellationToken);
    Task<Abstractions.User> UpdateUserAsync(User user, CancellationToken cancellationToken);

}


