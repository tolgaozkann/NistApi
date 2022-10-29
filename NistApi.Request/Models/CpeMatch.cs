using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NistApi.Request.Models
{
    public class CpeMatch
    {
        public bool vulnerable { get; set; }
        public string criteria { get; set; }
        public string matchCriteriaId { get; set; }
    }
}
