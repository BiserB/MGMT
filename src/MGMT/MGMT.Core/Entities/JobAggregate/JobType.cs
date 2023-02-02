using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGMT.Core.Entities.JobAggregate
{
    public class JobType : BaseEntity
    {
        public JobType(string type)
        {
            Type = type;
        }

        public string Type { get; set; }
    }
}
