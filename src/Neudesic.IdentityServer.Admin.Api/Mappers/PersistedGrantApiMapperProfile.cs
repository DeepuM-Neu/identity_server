using AutoMapper;
using Neudesic.IdentityServer.Admin.Api.Dtos.PersistedGrants;
using Neudesic.IdentityServer.Admin.BusinessLogic.Dtos.Grant;

namespace Neudesic.IdentityServer.Admin.Api.Mappers
{
    public class PersistedGrantApiMapperProfile : Profile
    {
        public PersistedGrantApiMapperProfile()
        {
            CreateMap<PersistedGrantDto, PersistedGrantApiDto>(MemberList.Destination);
            CreateMap<PersistedGrantDto, PersistedGrantSubjectApiDto>(MemberList.Destination);
            CreateMap<PersistedGrantsDto, PersistedGrantsApiDto>(MemberList.Destination);
            CreateMap<PersistedGrantsDto, PersistedGrantSubjectsApiDto>(MemberList.Destination);
        }
    }
}