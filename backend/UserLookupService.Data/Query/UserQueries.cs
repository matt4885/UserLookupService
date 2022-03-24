﻿using Microsoft.EntityFrameworkCore;
using UserLookupService.Data;

namespace UserLookupService.Data;

public class UserQueries : IUserQuery
{
    private readonly MainContext _dbContext;
    public UserQueries(MainContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <summary>
    /// Get user by Id
    /// </summary>
    /// <param name="id"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException"></exception>
    public async Task<Abstractions.User> GetUserAsync(Guid id, CancellationToken cancellationToken)
    {
        var user = await _dbContext.Users
            .Where(u => u.Id == id)
            .SingleOrDefaultAsync(cancellationToken)
            ?? throw new ArgumentNullException(nameof(id));

        return UserModelMapper.ToBusiness(user);
    }

    /// <summary>
    /// Get all users
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    public async Task<IList<User>> GetUsersAsync(CancellationToken cancellationToken)
    {
        var users = await _dbContext.Users
            .ToListAsync(cancellationToken);

        return users;
    }
}
