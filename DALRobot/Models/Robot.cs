using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALRobot.Models
{
    public class Robot
    {

        public int RobotID { get; set; }
        public String RobotName { get; set; }

        public Robot() { }

        public Robot(String name)
        {
            RobotName = name;
        }

        public Robot(int id, String name)
        {
            RobotID = id;
            RobotName = name;
        }

    }
}
