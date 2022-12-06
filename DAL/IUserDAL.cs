using System.Collections.Generic;
using DAL.Models;


namespace DAL
{
    public interface IUserDAL
    {
        public List<User> getAllUser();
        public User getUser(string id, string password);


    }
}