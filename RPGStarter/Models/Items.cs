using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RPGStarter.Models
{
    public class Items
    {

        [Key]
        public int itemID { get; set; }
        public string name { get; set; }
        public int value { get; set; }
        public float weight { get; set; }
        public int damage { get; set; }
        public int armorValue { get; set; }

    }
}