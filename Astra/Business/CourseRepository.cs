using Astra.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Astra.Business
{
    public class CourseRepository : Repository<Course>
    {
        private readonly AstraContext _astraContext = null;
        public CourseRepository(AstraContext astraContext)
            :base(astraContext)
        {
            _astraContext = astraContext;
        }

       
    }
}
