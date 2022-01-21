using UserLookupService.Abstractions;
using UserLookupService.Data;

namespace UserLookupService.Domains;

public class GetUserUseCase
{
    private readonly ILogger<GetUserUseCase> _logger;
    private readonly IUserQuery _userQuery;

    public GetUserUseCase(ILogger<GetUserUseCase> logger, IUserQuery userQuery)
    {
        _logger = logger;
        _userQuery = userQuery;
    }

    public async Task<Abstractions.User> GetUserAsync(Guid id, CancellationToken cancellationToken)
    {
        return await _userQuery.GetUserAsync(id, cancellationToken);
    }
}