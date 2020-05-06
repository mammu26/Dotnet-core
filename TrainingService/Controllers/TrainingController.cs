using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrainingService.Model;
using TrainingService.Services;

namespace TrainingService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TrainingServiceController : ControllerBase
    {
        private readonly ITrainingService _context;

        public TrainingServiceController(ITrainingService context)
        {
            _context = context;
        }

        // GET: api/AeTopology
        [HttpGet]
        public IEnumerable<Course> GetAllCourse()
        {
            return _context.GetAllCourse();
        }
    }
}