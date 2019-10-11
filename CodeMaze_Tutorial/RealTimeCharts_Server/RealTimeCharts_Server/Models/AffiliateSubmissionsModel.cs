using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealTimeCharts_Server.Models
{
    public class AffiliateSubmissionsModel
    {
        public string Name { get; set; }
        public List<SeriesModel> Series { get; set; }
    }

    public class SeriesModel
    {
        public string Name { get; set; } //May need to change 'type' to DateTime
        public int Value { get; set; }
    }
}

