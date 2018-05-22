using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RPGStarter.Models
{
    public class PlayerClass
    {
        public int PlayerID { get; set; }
        public int ClassID { get; set; }
        public Player Player { get; set; }
        //public Class Class { get; set; }
    }
}
