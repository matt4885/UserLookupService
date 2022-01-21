using UserLookupService.Abstractions;
using UserLookupService.Data;

namespace UserLookupService.Domains;

public class AddUserUseCase
{
    private readonly IUserRepository _userRepository;
    public AddUserUseCase(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<Abstractions.User> AddUserAsync(Abstractions.User user, CancellationToken cancellationToken)
    {
        user.Id = Guid.NewGuid();

        await _userRepository.AddAsync(user, cancellationToken);

        return user;
    }
}
