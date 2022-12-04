using AutoMapper;
using DL;
using DTO;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class UserBL : IUserBL
    {
        IUserDL _userDL;
        IMapper _mapper;
        public UserBL(IUserDL userDL, IMapper mapper)
        {
            _userDL = userDL;
            _mapper = mapper;
        }
        public async Task<int> post(UserDTO userDTO)
        {
            Users user = _mapper.Map<UserDTO, User>(userDTO);
            return await _userDL.post(user);
        }

        public Task<int> post(UsersDTO userDTO)
        {
            throw new NotImplementedException();
        }
    }

    internal interface IUserDL
    {
    }
}
