using AutoMapper;
using Skoruba.AuditLogging.EntityFramework.Entities;
using Neudesic.IdentityServer.Admin.BusinessLogic.Dtos.Log;
using Neudesic.IdentityServer.Admin.EntityFramework.Entities;
using Neudesic.IdentityServer.Admin.EntityFramework.Extensions.Common;

namespace Neudesic.IdentityServer.Admin.BusinessLogic.Mappers
{
    public class LogMapperProfile : Profile
    {
        public LogMapperProfile()
        {
            CreateMap<Log, LogDto>(MemberList.Destination)
                .ReverseMap();
            
            CreateMap<PagedList<Log>, LogsDto>(MemberList.Destination)
                .ForMember(x => x.Logs, opt => opt.MapFrom(src => src.Data));

            CreateMap<AuditLog, AuditLogDto>(MemberList.Destination)
                .ReverseMap();

            CreateMap<PagedList<AuditLog>, AuditLogsDto>(MemberList.Destination)
                .ForMember(x => x.Logs, opt => opt.MapFrom(src => src.Data));
        }
    }
}
