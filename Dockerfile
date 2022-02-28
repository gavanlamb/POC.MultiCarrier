FROM mcr.microsoft.com/dotnet/sdk:6.0-alpine AS base
ARG BUILD_NUMBER=0.0.0.1
ARG PAT
WORKDIR /poc-config
COPY "POC.Config.sln" "POC.Config.sln"
COPY "src/POC.Config.Api/POC.Config.Api.csproj" "src/POC.Config.Api/"
RUN dotnet restore POC.Config.sln 
COPY . .
RUN dotnet build -c Release /p:Version=$BUILD_NUMBER /p:AssemblyVersion=$BUILD_NUMBER /p:FileVersion=$BUILD_NUMBER


FROM base AS publish-api
RUN dotnet publish "src/POC.Config.Api/POC.Config.Api.csproj" -c Release -o /app/publish --no-build

FROM mcr.microsoft.com/dotnet/aspnet:6.0-alpine AS api
WORKDIR /app
COPY --from=publish-api /app/publish .
ENTRYPOINT ["dotnet", "POC.Config.Api.dll"]
