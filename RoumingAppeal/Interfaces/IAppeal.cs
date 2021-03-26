using RoumingAppeal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoumingAppeal.Interfaces
{
    public interface IAppeal
    {
        IEnumerable<Appeal> AllAppeals { get; set; }
        Appeal GetObjectAppael(int appealID);
    }
}
