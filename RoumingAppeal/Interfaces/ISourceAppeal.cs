using RoumingAppeal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoumingAppeal.Interfaces
{
    interface ISourceAppeal
    {
        IEnumerable<SourceAppeal> AllSources { get; }
    }
}
