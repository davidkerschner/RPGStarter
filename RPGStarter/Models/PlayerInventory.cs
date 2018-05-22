using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RPGStarter.Models
{
    public class PlayerInventory
    {
        public int PlayerID { get; set; }
        public int ItemID { get; set; }
        public Player Player { get; set; }
        public Item Item { get; set; }
    }
}
