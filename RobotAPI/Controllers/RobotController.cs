using DALRobot.Services;
using RobotAPI.Models;
using RobotAPI.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RobotAPI.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*")]
    public class RobotController : ApiController
    {
        
        private RobotStoreService robotService = new RobotStoreService();

        // GET: Robot
        [HttpGet]
        public IEnumerable<Robot> Get()
        {
            return robotService.GetAll().Select(r => r.toAPI());
        }

        // GET: Robot/id
        public Robot Get(int id)
        {
            try
            {
                return robotService.GetOne(id).toAPI();
            }
            catch
            {
                return new Robot { RobotID = -1 };
            }
        }


        // POST: Robot
        [HttpPost]
        public RobotResponse Post(Robot robot)
        {
            try
            {
               //add ok => return newRobot + ok status
               //add ko => return ko status
                if (robot.RobotName != null)
                {
                    Robot robotAdd = robotService.Create(robot.toDAL()).toAPI();                    
                    if (robotAdd != null)
                    {
                        RobotResponse response = new RobotResponse {
                            RobotID = robotAdd.RobotID,
                            RobotName = robotAdd.RobotName,
                            Status = 1
                        };
                        return response;
                    }
                }
                return new RobotResponse {Status = 0 };
            }
            catch
            {

                return new RobotResponse { Status = 0 };
            }
        }


        // POST: Robot/Delete/5
        [HttpDelete]
        public RobotResponse Delete(int id)
        {
            //delete ok => return ok status
            //delte ko => return ko status
            try
            {
                robotService.Delete(id);
                return new RobotResponse { Status = 1 };


            }
            catch
            {
                return new RobotResponse { Status = 0 };
            }
        }
    }
}
