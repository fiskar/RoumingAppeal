using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoumingAppeal.Models
{
    public class SourceAppeal
    {
        public int ID { get; set; }
        public string SourceName { get; set; }
        public List<Appeal> Appeals { get; set; }

    }
}
