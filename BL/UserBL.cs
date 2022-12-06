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
    }
}
