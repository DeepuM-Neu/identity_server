using System.Collections.Generic;
using Neudesic.IdentityServer.Admin.EntityFramework.Configuration.Configuration.Identity;

namespace Neudesic.IdentityServer.Admin.EntityFramework.Configuration.Configuration
{
	public class IdentityData
    {
       public List<Role> Roles { get; set; }
       public List<User> Users { get; set; }
    }
}
