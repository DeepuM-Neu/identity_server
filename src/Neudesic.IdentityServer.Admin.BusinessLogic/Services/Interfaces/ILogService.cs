using System;
using System.Threading.Tasks;
using Neudesic.IdentityServer.Admin.BusinessLogic.Dtos.Log;

namespace Neudesic.IdentityServer.Admin.BusinessLogic.Services.Interfaces
{
    public interface ILogService
    {
        Task<LogsDto> GetLogsAsync(string search, int page = 1, int pageSize = 10);

        Task DeleteLogsOlderThanAsync(DateTime deleteOlderThan);
    }
}