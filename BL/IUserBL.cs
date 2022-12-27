using DAL.Models;
using DTO.Models;
using System.Collections.Generic;
namespace BL
{
    public interface IUserBL
    {
        public UserDTO GetUser(string id, string password);
        bool AddUser(UserDTO user);
        bool DeleteUser(string id);
        bool UpdateUser(string id, UserDTO user);
    }
}