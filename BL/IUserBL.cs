using DAL.Models;
using DTO.Models;
using System.Collections.Generic;
namespace BL
{
    public interface IUserBL
    {
       public UserDTO GetUser(string id, string password);
    }
}