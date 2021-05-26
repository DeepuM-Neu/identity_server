$packagesOutput = ".\packages"

# Business Logic
dotnet pack .\..\src\Neudesic.IdentityServer.Admin.BusinessLogic\Neudesic.IdentityServer.Admin.BusinessLogic.csproj -c Release -o $packagesOutput
dotnet pack .\..\src\Neudesic.IdentityServer.Admin.BusinessLogic.Identity\Neudesic.IdentityServer.Admin.BusinessLogic.Identity.csproj -c Release -o $packagesOutput
dotnet pack .\..\src\Neudesic.IdentityServer.Admin.BusinessLogic.Shared\Neudesic.IdentityServer.Admin.BusinessLogic.Shared.csproj -c Release -o $packagesOutput
dotnet pack .\..\src\Neudesic.IdentityServer.Shared.Configuration\Neudesic.IdentityServer.Shared.Configuration.csproj -c Release -o $packagesOutput

# EF
dotnet pack .\..\src\Neudesic.IdentityServer.Admin.EntityFramework\Neudesic.IdentityServer.Admin.EntityFramework.csproj -c Release -o $packagesOutput
dotnet pack .\..\src\Neudesic.IdentityServer.Admin.EntityFramework.Extensions\Neudesic.IdentityServer.Admin.EntityFramework.Extensions.csproj -c Release -o $packagesOutput
dotnet pack .\..\src\Neudesic.IdentityServer.Admin.EntityFramework.Identity\Neudesic.IdentityServer.Admin.EntityFramework.Identity.csproj -c Release -o $packagesOutput
dotnet pack .\..\src\Neudesic.IdentityServer.Admin.EntityFramework.Shared\Neudesic.IdentityServer.Admin.EntityFramework.Shared.csproj -c Release -o $packagesOutput
dotnet pack .\..\src\Neudesic.IdentityServer.Admin.EntityFramework.Configuration\Neudesic.IdentityServer.Admin.EntityFramework.Configuration.csproj -c Release -o $packagesOutput

# UI
dotnet pack .\..\src\Neudesic.IdentityServer.Admin.UI\Neudesic.IdentityServer.Admin.UI.csproj -c Release -o $packagesOutput
