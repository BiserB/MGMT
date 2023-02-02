using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGMT.Core.Exceptions
{
    public class JobNotFoundException : Exception
    {
        public JobNotFoundException(int jobId) : base($"No job found with id {jobId}")
        { }
    }
}
