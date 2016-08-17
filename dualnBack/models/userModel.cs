using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dualnBack.models
{
    public class userModel
    {
        public int id { get; set; }
        public string user { get; set; }
        public int? score { get; set; }
        public int? logs { get; set; } 
        
    }

    public class userLog
    {
        public DateTime fecha { get; set; }
    }
}
