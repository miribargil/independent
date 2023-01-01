using System.Collections.Generic;
using DAL.Models;


namespace DAL
{
    public interface IUserDAL
    {
        public List<User> getAllUser();
        public User getUser(string id, string password);
        bool AddUser(User user);
        bool DeleteUser(string id);
        bool UpdateUsers(string id, User user);
        bool UpdatePassword(string id, string mail);

    }
}