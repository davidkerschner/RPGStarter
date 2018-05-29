using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RPGStarter.Models
{
    public class Mob
    {
        [Key]
        public int MobID { get; set; }

        [Required]
        public string MobName { get; set; }

        [Required]
        public int ItemID { get; set; }

        [Required]
        public string ItemName { get; set; }

        [Required]
        public int StatID { get; set; }

        [Required]
        public Boolean is_hostile { get; set; }
    }
}
