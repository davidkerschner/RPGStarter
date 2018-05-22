using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RPGStarter.Models
{
    public class Mob
    {
        [Required]
        public int mob_id { get; set; }

        [Required]
        public string mob_name { get; set; }

        [Required]
        public int item_id { get; set; }

        [Required]
        public string item_name { get; set; }

        [Required]
        public int stat_id { get; set; }

        [Required]
        public Boolean is_hostile { get; set; }
    }
}
