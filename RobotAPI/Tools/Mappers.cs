using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RobotAPI.Tools
{
    public static class Mappers
    {
        public static DALRobot.Models.Robot toDAL(this RobotAPI.Models.Robot r)
        {
            return new DALRobot.Models.Robot
            {
                RobotID = r.RobotID,
                RobotName = r.RobotName
            };
        }
        public static RobotAPI.Models.Robot toAPI(this DALRobot.Models.Robot r)
        {
            return new RobotAPI.Models.Robot
            {
                RobotID = r.RobotID,
                RobotName = r.RobotName
            };
        }
    }
}