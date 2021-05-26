FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/Neudesic.IdentityServer.Admin.Api/Neudesic.IdentityServer.Admin.Api.csproj", "src/Neudesic.IdentityServer.Admin.Api/"]
COPY ["src/Neudesic.IdentityServer.Admin.EntityFramework.MySql/Neudesic.IdentityServer.Admin.EntityFramework.MySql.csproj", "src/Neudesic.IdentityServer.Admin.EntityFramework.MySql/"]
COPY ["src/Neudesic.IdentityServer.Admin.EntityFramework.Identity/Neudesic.IdentityServer.Admin.EntityFramework.Identity.csproj", "src/Neudesic.IdentityServer.Admin.EntityFramework.Identity/"]
COPY ["src/Neudesic.IdentityServer.Admin.EntityFramework/Neudesic.IdentityServer.Admin.EntityFramework.csproj", "src/Neudesic.IdentityServer.Admin.EntityFramework/"]
COPY ["src/Neudesic.IdentityServer.Admin.EntityFramework.Extensions/Neudesic.IdentityServer.Admin.EntityFramework.Extensions.csproj", "src/Neudesic.IdentityServer.Admin.EntityFramework.Extensions/"]
COPY ["src/Neudesic.IdentityServer.Admin.EntityFramework.Shared/Neudesic.IdentityServer.Admin.EntityFramework.Shared.csproj", "src/Neudesic.IdentityServer.Admin.EntityFramework.Shared/"]
COPY ["src/Neudesic.IdentityServer.Admin.EntityFramework.Configuration/Neudesic.IdentityServer.Admin.EntityFramework.Configuration.csproj", "src/Neudesic.IdentityServer.Admin.EntityFramework.Configuration/"]
COPY ["src/Neudesic.IdentityServer.Admin.BusinessLogic/Neudesic.IdentityServer.Admin.BusinessLogic.csproj", "src/Neudesic.IdentityServer.Admin.BusinessLogic/"]
COPY ["src/Neudesic.IdentityServer.Admin.BusinessLogic.Shared/Neudesic.IdentityServer.Admin.BusinessLogic.Shared.csproj", "src/Neudesic.IdentityServer.Admin.BusinessLogic.Shared/"]
COPY ["src/Neudesic.IdentityServer.Admin.EntityFramework.PostgreSQL/Neudesic.IdentityServer.Admin.EntityFramework.PostgreSQL.csproj", "src/Neudesic.IdentityServer.Admin.EntityFramework.PostgreSQL/"]
COPY ["src/Neudesic.IdentityServer.Shared.Configuration/Neudesic.IdentityServer.Shared.Configuration.csproj", "src/Neudesic.IdentityServer.Shared.Configuration/"]
COPY ["src/Neudesic.IdentityServer.Admin.BusinessLogic.Identity/Neudesic.IdentityServer.Admin.BusinessLogic.Identity.csproj", "src/Neudesic.IdentityServer.Admin.BusinessLogic.Identity/"]
COPY ["src/Neudesic.IdentityServer.Shared/Neudesic.IdentityServer.Shared.csproj", "src/Neudesic.IdentityServer.Shared/"]
COPY ["src/Neudesic.IdentityServer.Admin.EntityFramework.SqlServer/Neudesic.IdentityServer.Admin.EntityFramework.SqlServer.csproj", "src/Neudesic.IdentityServer.Admin.EntityFramework.SqlServer/"]
RUN dotnet restore "src/Neudesic.IdentityServer.Admin.Api/Neudesic.IdentityServer.Admin.Api.csproj"
COPY . .
WORKDIR "/src/src/Neudesic.IdentityServer.Admin.Api"
RUN dotnet build "Neudesic.IdentityServer.Admin.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Neudesic.IdentityServer.Admin.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_FORWARDEDHEADERS_ENABLED=true
ENTRYPOINT ["dotnet", "Neudesic.IdentityServer.Admin.Api.dll"]
