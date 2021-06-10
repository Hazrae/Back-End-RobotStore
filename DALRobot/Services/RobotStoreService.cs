using DALRobot.Context;
using DALRobot.Models;
using DALRobot.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace DALRobot.Services
{
    public class RobotStoreService : Service, IRobotStore
    {
        public Robot Create(Robot entity)
        {          
            if (entity.RobotName == null)
                return null;
            context.Robots.Add(entity);
            context.SaveChanges();
            return new Robot(entity.RobotID, entity.RobotName) ;
        }

        public void Delete(int id)
        {
            try
            {
                Robot robot = context.Robots.Find(id);
                context.Robots.Remove(robot);
                context.SaveChanges();
            }
            catch
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public List<Robot> GetAll()
        {
            return context.Robots.ToList();
        }

        public Robot GetOne(int id)
        {

            // Get robot
            // robot with id = -1 if not found
            try
            {
                Robot robot = context.Robots.Find(id);
                if (robot != null)
                    return robot;
                else
                    return new Robot { RobotID = -1 };
            }
            catch
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}
