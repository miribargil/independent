using DAL.Models;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using DAL;
using AutoMapper;
using DTO.Models;

namespace BL
{
    public class UserBL : IUserBL
    {
        IUserDAL userDAL;
        IMapper _mapper;
        public UserBL(IUserDAL _userDAL, IMapper mapper)
        {
            userDAL = _userDAL;
            _mapper = mapper;
        }
        public UserDTO GetUser(string id, string password)
        {
            User user = userDAL.getUser(id, password);
            UserDTO userDTO = _mapper.Map<User, UserDTO>(user);
            return userDTO;
        }
        public bool AddUser(UserDTO user)
        {
            return userDAL.AddUser(_mapper.Map<UserDTO, User>(user));
        }
        public bool DeleteUser(string id)
        {
            return userDAL.DeleteUser(id);
        }
        public bool UpdateUser(string id, UserDTO user)
        {
            User user1 = _mapper.Map<UserDTO, User>(user);
            return userDAL.UpdateUsers(id, user1);
        }
    }
}
