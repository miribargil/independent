
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class UserDL : IUserDL
    {


        tachlesNewspaperContext _tachlesContext;
        public UserDL(tachlesNewspaperContext tachlesContext)
        {
            _tachlesContext = tachlesContext;
        }
        public async Task<int> post(Users user)
        {
            await _tachlesContext.Users.AddAsync(user);
            await _tachlesContext.SaveChangesAsync();
            return user.UserId;
        }
    }
}
