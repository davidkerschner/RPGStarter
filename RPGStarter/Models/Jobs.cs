using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RPGStarter.Models
{
    public class Jobs
    {
        public int jobID { get; set; }
        public string jobName { get; set; }
        public int jobStr { get; set; }
        public int jobCon { get; set; }
        public int jobInt { get; set; }
        public int jobDex { get; set; }
        public int jobHealth { get; set; }
        public int jobLuck { get; set; }
    }
}
