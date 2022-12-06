using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL
{
    public class UserDAL : IUserDAL
    {
        independent_momContext _MomContext;
        public List<User> getAllUser()
        {
             return _MomContext.Users.ToList();
             
        }

        public User getUser(string id, string password)
        {
            return _MomContext.Users.Where(x => x.Id == id && x.Password == password).FirstOrDefault();
        }
    }
}
