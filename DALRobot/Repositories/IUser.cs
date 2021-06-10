using DALRobot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALRobot.Repositories
{
    interface IUser : IRepository<User>
    {
        User Login(String username, String password);
    }
}
