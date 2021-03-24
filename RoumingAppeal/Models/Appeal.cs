using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoumingAppeal.Models
{
    public class Appeal
    {
        public int ID { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string City { get; set; }
        public string ClientPhoneNumber { get; set; }
        public string ReasonAppeal { get; set; }
        public int SourceAppealID { get; set; }
        public SourceAppeal SourceAppeal { get; set; }
     }
}
