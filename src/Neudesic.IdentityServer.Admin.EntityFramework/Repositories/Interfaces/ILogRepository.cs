using System;
using System.Threading.Tasks;
using Neudesic.IdentityServer.Admin.EntityFramework.Entities;
using Neudesic.IdentityServer.Admin.EntityFramework.Extensions.Common;

namespace Neudesic.IdentityServer.Admin.EntityFramework.Repositories.Interfaces
{
    public interface ILogRepository
    {
        Task<PagedList<Log>> GetLogsAsync(string search, int page = 1, int pageSize = 10);

        Task DeleteLogsOlderThanAsync(DateTime deleteOlderThan);

        bool AutoSaveChanges { get; set; }
    }
}