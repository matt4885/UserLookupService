using UserLookupService.Abstractions;
using UserLookupService.Data;

namespace UserLookupService.Domains;


public class DeleteUserUseCase
{
    // private properties should be underscore 
    private readonly ILogger<DeleteUserUseCase> _logger;
    private readonly IUserRepository _userRepository;
    // repository interacts with the data 
    // query finds the data 
    public DeleteUserUseCase(IUserRepository userRepository, ILogger<DeleteUserUseCase> logger)
    {
        _userRepository = userRepository;
        _logger = logger;
    }

    public async Task DeleteUserAsync(Guid userId, CancellationToken cancellationToken)
    {
        _logger.LogInformation("Attempting to delete user: [{userId}]", userId);
        await _userRepository.DeleteUserAsync(userId, cancellationToken);
    } 
}
