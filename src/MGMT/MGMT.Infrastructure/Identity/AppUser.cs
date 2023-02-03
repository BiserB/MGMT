using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGMT.Infrastructure.Identity
{
    public class AppUser : IdentityUser
    {
        public AppUser() : base()
        {
            CreatedOn= DateTime.UtcNow;
        }

        public DateTime CreatedOn { get; private set; }
    }
}
