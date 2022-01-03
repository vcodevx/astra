using Astra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Astra.Business
{
    public class UserRepository : Repository<User>
    {
        private readonly AstraContext _astraContext = null;
        public UserRepository(AstraContext astraContext)
            : base(astraContext)
        {
            _astraContext = astraContext;
        }

    }
}
