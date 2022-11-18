using NoodleAssignmentProj.Models;
using NoodleAssignmentProj.Service.IService;
using System;

namespace NoodleAssignmentProj.Service
{
    public class Assignment : IAssignment
    {
        public IEnumerable<DemoClass> FetchDemoData(string[] designations) =>
             Enumerable.Range(1, 5).Select(index => new DemoClass
            {
                ID= index,
                Name="Chethan "+index.ToString(),
                Description = designations[Random.Shared.Next(designations.Length)]
             })
            .ToArray();
}
}
