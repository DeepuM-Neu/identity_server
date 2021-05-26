using System;
using System.Threading.Tasks;
using Neudesic.IdentityServer.Admin.BusinessLogic.Dtos.Log;

namespace Neudesic.IdentityServer.Admin.BusinessLogic.Services.Interfaces
{
    public interface IAuditLogService
    {
        Task<AuditLogsDto> GetAsync(AuditLogFilterDto filters);

        Task DeleteLogsOlderThanAsync(DateTime deleteOlderThan);
    }
}
