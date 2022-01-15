using Microsoft.AspNetCore.Mvc;
using System.Net;
using UserLookupService.Domains;

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
    public async Task<IActionResult> Get([FromRoute] Guid id, CancellationToken cancellationToken)
    {
        var getUserUseCase = _serviceProvider.GetRequiredService<GetUserUseCase>();

        var user = await getUserUseCase.GetUserAsync(id, cancellationToken);
        
        return Ok(user);
    }
}
