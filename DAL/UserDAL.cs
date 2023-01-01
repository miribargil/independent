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
        public UserDAL(independent_momContext momContext)
        {
            _MomContext = momContext;
        }
        public List<User> getAllUser()
        {
             return _MomContext.Users.ToList();
             
        }

        public User getUser(string id, string password)
        {
            return _MomContext.Users.Where(x => x.Id == id && x.Password == password).FirstOrDefault();
        }

        public bool AddUser(User user)
        {
            try
            {
                _MomContext.Users.Add(user);
                _MomContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool DeleteUser(string id)
        {
            try
            {
                User user = _MomContext.Users.SingleOrDefault(x => x.Id == id);
                _MomContext.Users.Remove(user);
                _MomContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateUsers(string id, User user)
        {
            try
            {
                User user1 = _MomContext.Users.SingleOrDefault(x => x.Id == id);
                _MomContext.Entry(user1).CurrentValues.SetValues(user);
                _MomContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public bool UpdatePassword(string id, string mail)
        {
            try
            {
              User user3=  _MomContext.Users.Where(x => x.Id == id&&x.Email==mail).FirstOrDefault();
                User user1 = _MomContext.Users.SingleOrDefault(x => x.Id == id);
                User user = new User();
                Random rnd = new Random();
                string s = "";
                for (int i = 0; i < 5; i++)
                {
                    
                     s += rnd.Next(10).ToString();
                }
                user.FName = user1.FName;
                user.LName = user1.LName;
                user.Id = id;
                user.IdKupa = user1.IdKupa;
                user.PhNum = user1.PhNum;
                user.Email = user1.Email; 
                user.Password = s;
                _MomContext.Entry(user1).CurrentValues.SetValues(user);
                _MomContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
