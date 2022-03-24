namespace UserLookupService.Data;

public interface IUserQuery
{
    Task<Abstractions.User> GetUserAsync(Guid id, CancellationToken cancellationToken);
    Task<IList<User>> GetUsersAsync(CancellationToken cancellationToken);
}