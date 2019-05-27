using CoreStart.Domain.Model;
using CoreStart.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreStart.Service
{
    public interface IUserService : IService<User, UserDto, int>
    {
    }
}
