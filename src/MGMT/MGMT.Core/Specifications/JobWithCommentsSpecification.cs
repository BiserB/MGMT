using Ardalis.Specification;
using MGMT.Core.Entities.JobAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGMT.Core.Specifications
{
    public class JobWithCommentsSpecification : Specification<Job>, ISingleResultSpecification
    {
        public JobWithCommentsSpecification(int jobId) 
        {
            Query
                .Where(j => j.Id == jobId)
                .Include(j => j.Comments);
        }
    }
}
