using MGMT.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGMT.Core.Entities.JobAggregate
{
    public class CommentType : BaseEntity, IAggregateRoot
    {
        public CommentType(string type)
        {
            Type = type;
        }

        public string Type { get; private set; }
    }
}
