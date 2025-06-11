using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Malshinon.Data
{
    internal class Reports
    {
        public int id { get; set; }
        public int reporter_id { get; set; }
        public int target_id { get; set; }
        public string text { get; set; }
        public DateTime timestamp { get; set; }

    }
}
