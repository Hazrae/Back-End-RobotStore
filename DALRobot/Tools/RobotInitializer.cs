using DALRobot.Context;
using DALRobot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALRobot.Tools
{
    class RobotInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<RobotContext>
    {
        protected override void Seed(RobotContext context)
        {
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
