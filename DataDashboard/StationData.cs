using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataDashboard
{
    class StationData
    {
        public string StationName { get; set; }

        public int screen_id { get; set; }

        public DateTime date { get; set; }

        public double depth_to_water_level { get; set; }

        public string comment { get; set; }
    }
}
