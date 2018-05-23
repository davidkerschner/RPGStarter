using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RPGStarter.Models
{ 
public class World
{
	// an Id to keep track of location/possible movement
        public int worldID { get; set; }
    // a player displayed name for where they are
        public string roomName { get; set; }
    // the description of the location the player is in
        public string roomDesc { get; set; }
    // an ID to indicate what event is set for this location example 1.Mob 2.Treasure
        public int eventID { get; set; }

        
	}
}
