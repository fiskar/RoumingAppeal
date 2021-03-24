using RoumingAppeal.Interfaces;
using RoumingAppeal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoumingAppeal.Mocks
{
    public class MockAppeal : IAppeal
    {
        private readonly ISourceAppeal _appealSource = new MockSource();
        public IEnumerable<Appeal> AllAppeals 
        { get
            {
                return new List<Appeal>
                {
                    new Appeal { Country = "Англия", Region = "Большой Лондон", City="Лондон", ClientPhoneNumber="9527273199", ReasonAppeal="Ошибка регистрации SIM", SourceAppeal= _appealSource.AllSources.Last()},
                    new Appeal { Country = "Монголия", Region = "Улан-Батор", City="Улан-Батор", ClientPhoneNumber="9043828261", ReasonAppeal="Низкий уровень сигнала", SourceAppeal=_appealSource.AllSources.ElementAt(0)}
                };
            }
            set { }
        }
        public Appeal GetObjectAppael(int appealID)
        {
            throw new NotImplementedException();
        }
    }
}
