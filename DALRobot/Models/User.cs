using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALRobot.Models
{
    public class User
    {       

        public int UserID { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public Boolean IsAdmin { get; set; }

      
    }
}
