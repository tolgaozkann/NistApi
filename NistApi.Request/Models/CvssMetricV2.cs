using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NistApi.Request.Models
{
    public class CvssMetricV2
    {
        public string source { get; set; }
        public string type { get; set; }
        public CvssData cvssData { get; set; }
        public double exploitabilityScore { get; set; }
        public double impactScore { get; set; }
        public bool acInsufInfo { get; set; }
        public bool obtainAllPrivilege { get; set; }
        public bool obtainUserPrivilege { get; set; }
        public bool obtainOtherPrivilege { get; set; }
        public bool userInteractionRequired { get; set; }
    }
}
