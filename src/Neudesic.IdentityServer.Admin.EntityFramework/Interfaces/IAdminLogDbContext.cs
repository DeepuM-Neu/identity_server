using Microsoft.EntityFrameworkCore;
using Neudesic.IdentityServer.Admin.EntityFramework.Entities;

namespace Neudesic.IdentityServer.Admin.EntityFramework.Interfaces
{
    public interface IAdminLogDbContext
    {
        DbSet<Log> Logs { get; set; }
    }
}
