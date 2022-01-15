using UserLookupService.Abstractions;

namespace UserLookupService.Domains;

public class GetUserUseCase
{
    private readonly ILogger<GetUserUseCase> _logger;
        
    public GetUserUseCase(ILogger<GetUserUseCase> logger)
    {
        _logger = logger;
    }

    public async Task<User> GetUserAsync(Guid id, CancellationToken cancellationToken)
    {
        return new User
        {
            Id = id,
            DateOfBirth = new DateTime(1992, 09, 18),
            GivenName = "Matt",
            FamilyName = "Kempey",
            Address = "123 Fake St.",
            Email = "mkempey@gmail.com"
        };
    }
}