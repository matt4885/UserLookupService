using Microsoft.AspNetCore.Mvc;
using UserLookupService.Domains;
using UserLookupService.Abstractions;
using UserLookupService.Data;

namespace UserLookupService.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    
    private readonly ILogger<UserController> _logger;
    private readonly IServiceProvider _serviceProvider;

    public UserController(ILogger<UserController> logger, IServiceProvider serviceProvider)
    {
        _logger = logger;
        _serviceProvider = serviceProvider;
    }

    [HttpGet("{id:Guid}")]
    public async Task<IActionResult> GetUserById([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var getUserUseCase = _serviceProvider.GetRequiredService<GetUserUseCase>();

        var user = await getUserUseCase.GetUserAsync(id, cancellationToken);
        
        return Ok(user);
    }

    [HttpPost]
    public async Task<IActionResult> AddUser([FromBody] AddUser user, CancellationToken cancellationToken)
    {
        var addUserUseCase = _serviceProvider.GetRequiredService<AddUserUseCase>();

        var createdUser = await addUserUseCase.AddUserAsync(UserModelMapper.ToBusiness(user), cancellationToken);

        return Created($"{createdUser.Id}", createdUser);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteUserAsync([FromRoute] Guid id, CancellationToken cancellationToken = default)
    {
        var deleteUserUseCase = _serviceProvider.GetRequiredService<DeleteUserUseCase>();

        await deleteUserUseCase.DeleteUserAsync(id, cancellationToken);

        return NoContent();

    }

    [HttpPut]
    public async Task<IActionResult> UpdateUser([FromBody] Abstractions.User user, CancellationToken cancellationToken)
    {
        
        var updateUserUseCase = _serviceProvider.GetRequiredService<UpdateUserUseCase>();

        var updatedUser = await updateUserUseCase.UpdateUserAsync(user, cancellationToken);

        return Ok();
    }
}

