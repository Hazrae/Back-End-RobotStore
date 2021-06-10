using DALRobot.Context;
using DALRobot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DALRobot.Tools
{
    class RobotInitializer : System.Data.Entity.DropCreateDatabaseAlways<RobotContext>
    {
        protected override void Seed(RobotContext context)
        {

            List<User> users = new List<User>
            {
                new User{ Username ="test", Password="test", IsAdmin = false},
                new User{ Username ="admin", Password="admin", IsAdmin = true}
            };
            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();

            List<Robot> robots = new List<Robot>
            {
                new Robot{RobotName="Nono"},
                new Robot{RobotName="Optimus"},
                new Robot{RobotName="R2D2"},
                new Robot{RobotName="BH6"}
            };
            robots.ForEach(r => context.Robots.Add(r)) ;
            context.SaveChanges();

            
        }

        
    }
}
