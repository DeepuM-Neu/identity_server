using Neudesic.IdentityServer.Admin.BusinessLogic.Helpers;

namespace Neudesic.IdentityServer.Admin.BusinessLogic.Resources
{
    public interface IPersistedGrantServiceResources
    {
        ResourceMessage PersistedGrantDoesNotExist();

        ResourceMessage PersistedGrantWithSubjectIdDoesNotExist();
    }
}
