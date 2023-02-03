using Ardalis.Specification;
using MGMT.Core.Entities.JobAggregate;
using MGMT.Core.Entities.WorkerAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGMT.Core.Specifications
{
    public class WorkerJobsSpecification : Specification<Job>
    {
        public WorkerJobsSpecification(int workerId)
        {
            Query.Where(j => j.CreatorId == workerId);
        }
    }
}
