using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RPGStarter.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string OwnerID { get; set; }
        public string Name { get; set; }
        public int StatID { get; set; }
       // public Stat Stat { get; set; }
    }
}
