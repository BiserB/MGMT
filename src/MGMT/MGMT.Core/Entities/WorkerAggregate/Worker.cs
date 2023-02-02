using MGMT.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGMT.Core.Entities.WorkerAggregate
{
    public class Worker : BaseEntity, IAggregateRoot
    {
        public string IdentityGuid { get; private set; }

        #pragma warning disable CS8618 // Required by Entity Framework
        private Worker()
        { }

        public Worker(string identityGuid) : this()
        {
            IdentityGuid = identityGuid;
        }
    }
}
