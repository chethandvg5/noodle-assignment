using Microsoft.AspNetCore.Mvc;
using NoodleAssignmentProj.Models;
using NoodleAssignmentProj.Service.IService;

namespace NoodleAssignmentProj.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : ControllerBase
    {
        private static readonly string[] Designations = new[]
        {
        "Software Engineer", "Developer", "Software Architect", "Senior Software Engineer", "CEO", "Chief Engineer", "Data Analyst", "Data Scientist", "Data Engineer", "Senior Data Analyst"
    };
        private IAssignment _assignment;

        public DemoController(IAssignment assignment)=>
            _assignment = assignment;

        [HttpGet(Name = "GetDemoData")]
        public IEnumerable<DemoClass> Get()=>
             _assignment.FetchDemoData(Designations);            
        
    }
}