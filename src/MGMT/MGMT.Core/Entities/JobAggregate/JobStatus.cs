using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGMT.Core.Entities.JobAggregate
{
    public class JobStatus : BaseEntity
    {
        public JobStatus(string status)
        {
            Status = status;
        }

        public string Status { get; set; }
    }
}
