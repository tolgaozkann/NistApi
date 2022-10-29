using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NistApi.Request.Models
{
    public class Node
    {
        public string @operator { get; set; }
        public bool negate { get; set; }
        public List<CpeMatch> cpeMatch { get; set; }
    }
}
