using RoumingAppeal.Interfaces;
using RoumingAppeal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoumingAppeal.Mocks
{
    public class MockSource : ISourceAppeal
    {
        public IEnumerable<SourceAppeal> AllSources 
        { get
            {
                return new List<SourceAppeal>
                {
                    new SourceAppeal { SourceName="Контакт-Центр"},
                    new SourceAppeal { SourceName="Офис Вайнера"},
                    new SourceAppeal { SourceName="Офис Шейкмана"},
                    new SourceAppeal { SourceName="Офис Пикадилли"}
                };
            }
        }
    }
}
