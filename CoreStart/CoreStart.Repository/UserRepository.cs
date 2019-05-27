using CoreStart.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreStart.Repository
{
    public class UserRepository : BaseRepository<User, int>, IUserRepository
    {
        public UserRepository(BaseDbContext baseDbContext) : base(baseDbContext)
        {
        }
    }
}
