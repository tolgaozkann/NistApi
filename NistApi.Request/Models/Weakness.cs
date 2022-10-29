using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NistApi.Request.Models
{
    public class Weakness
    {
        public string source { get; set; }
        public string type { get; set; }
        public List<Description> description { get; set; }
    }
}
