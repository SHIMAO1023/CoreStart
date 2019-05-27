using CoreStart.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreStart.Repository
{
    public interface IUserRepository : IRepository<User, int>
    {
    }
}
