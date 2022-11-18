using NoodleAssignmentProj.Models;

namespace NoodleAssignmentProj.Service.IService
{
    public interface IAssignment
    {
        public IEnumerable<DemoClass> FetchDemoData(string[] designations);
    }
}
