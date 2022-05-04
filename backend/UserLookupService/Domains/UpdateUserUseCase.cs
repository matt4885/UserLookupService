using UserLookupService.Abstractions;
using UserLookupService.Data;


namespace UserLookupService.Domains;
// controller, use case, interface, data base implementation 

public class UpdateUserUseCase
{
    private readonly IUserRepository _userRepository;
   
    public UpdateUserUseCase(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }


    public async Task<Abstractions.User> UpdateUserAsync(Abstractions.User user, CancellationToken cancellationToken)
    {
        // calling static method to convert business model to data model.
       var updatedUser = await _userRepository.UpdateUserAsync(UserModelMapper.ToDatabase(user), cancellationToken);

        return updatedUser;
    }
    




} 


