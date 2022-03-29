using UserLookupService.Abstractions;

namespace UserLookupService.Data;

public interface IUserQuery
{
    Task<Abstractions.User> GetUserAsync(Guid id, CancellationToken cancellationToken);
    Task<IList<Abstractions.User>> GetUsersAsync(CancellationToken cancellationToken);
    Task<IList<Abstractions.User>> GetUsersAsync(State state, CancellationToken cancellationToken);
    Task<IList<Abstractions.User>> GetUsersAsync(string zipCode, CancellationToken cancellationToken);
}