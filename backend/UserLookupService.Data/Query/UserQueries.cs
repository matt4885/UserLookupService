using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLookupService.Data.Query
{
    public class UserQueries
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
        public async Task<User> GetUserAsync(Guid id, CancellationToken cancellationToken)
        {
            var user = await _dbContext.Users
                .Where(u => u.Id == id)
                .SingleOrDefaultAsync(cancellationToken)
                ?? throw new ArgumentNullException(nameof(id));

            return user;
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
}
