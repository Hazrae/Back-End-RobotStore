﻿using RobotAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using DALRobot.Services;
using RobotAPI.Tools;
using System.Web.Http;

namespace RobotAPI.Controllers
{
    public class UserController : ApiController
    {
        private UserService userServ = new UserService();
        [HttpPost]
        public User Login(UserForm user)
        {
            return userServ.Login(user.Username, user.Password).toAPI();
        }

        // GET: api/user
       [HttpGet]
        public UserForm GetTest()
        {
            return new UserForm { Username = "test", Password = "test"};
        }       
    }
}
