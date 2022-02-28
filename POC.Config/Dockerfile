FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["POC.Config/POC.Config.csproj", "POC.Config/"]
RUN dotnet restore "POC.Config/POC.Config.csproj"
COPY . .
WORKDIR "/src/POC.Config"
RUN dotnet build "POC.Config.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "POC.Config.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "POC.Config.dll"]
