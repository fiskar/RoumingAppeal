using RoumingAppeal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoumingAppeal.ViewModels
{
    public class AppealsListViewModel
    {
        public IEnumerable<Appeal> allAppeals { get; set; }
        public string currentSource { get; set; }
    }
}
