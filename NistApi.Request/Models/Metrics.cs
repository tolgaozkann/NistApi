using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NistApi.Request.Models
{
    public class Metrics
    {
        public List<CvssMetricV2> cvssMetricV2 { get; set; }
    }
}
