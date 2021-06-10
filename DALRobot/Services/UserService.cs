using DALRobot.Models;
using DALRobot.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALRobot.Services
{

    public class UserService : Service, IUser
    {        
        public User Create(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public User Login(string username, string password)
        {          
            User loggedUser = context.Users.FirstOrDefault(u=> u.Username.Equals(username)  && u.Password.Equals(password));
            if (loggedUser != null)
                return loggedUser;
            else
                return new User { UserID = -1 };
        }
    }
}
