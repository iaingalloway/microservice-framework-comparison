FROM mcr.microsoft.com/dotnet/sdk:10.0.203 AS build
WORKDIR /src

COPY "src/csharp-aspnetcore/Service/Service.csproj" Service/Service.csproj
RUN --mount=type=cache,id=nuget,target=/root/.nuget/packages dotnet restore "Service/Service.csproj"

COPY src/csharp-aspnetcore/ .
RUN --mount=type=cache,id=nuget,target=/root/.nuget/packages dotnet publish "Service/Service.csproj" -c Release -o /out --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:10.0.5
WORKDIR /app

COPY --from=build /out .

EXPOSE 8080
ENTRYPOINT ["dotnet", "Service.dll"]
