using Astra.Business;
using Astra.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Astra.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        public readonly AstraContext _astraContext = null;
        public CourseController(AstraContext astraContext)
        {
            _astraContext = astraContext;
        }

        [Route("GetAllCourses")]
        [HttpGet]
        public ActionResult<IEnumerable<Course>> GetAllCourses()
        {
            var courseRepo = new CourseRepository(_astraContext);
            var allCourses = courseRepo.Get(x => x.CourseID != Guid.Empty).ToList();
            if (allCourses != null)
                return Ok(allCourses);
            else
                return NoContent();
        }


    }
}
