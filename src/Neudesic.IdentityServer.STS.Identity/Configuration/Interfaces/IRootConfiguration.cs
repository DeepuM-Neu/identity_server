using Neudesic.IdentityServer.Shared.Configuration.Configuration.Identity;

namespace Neudesic.IdentityServer.STS.Identity.Configuration.Interfaces
{
    public interface IRootConfiguration
    {
        AdminConfiguration AdminConfiguration { get; }

        RegisterConfiguration RegisterConfiguration { get; }
    }
}