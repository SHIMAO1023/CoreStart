using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CoreStart.Domain.Model;
using CoreStart.Dto;
using CoreStart.Repository;

namespace CoreStart.Service
{
    public class UserService : BaseService<User, UserDto, int>, IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper) : base(userRepository, mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }
    }
}
