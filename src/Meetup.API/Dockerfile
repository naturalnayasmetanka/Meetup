FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base

WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build

WORKDIR /src

COPY ["src/Meetup.API/Meetup.API.csproj", "src/Meetup.API/"]
COPY ["src/Meetup.Application/Meetup.Application.csproj", "src/Meetup.Application/"]
COPY ["src/Meetup.Domain/Meetup.Domain.csproj", "src/Meetup.Domain/"]
COPY ["src/Meetup.Infrastructure/Meetup.Infrastructure.csproj", "src/Meetup.Infrastructure/"]
COPY ["src/Meetup.Persistence/Meetup.Persistence.csproj", "src/Meetup.Persistence/"]

RUN dotnet restore "src/Meetup.API/Meetup.API.csproj"
COPY . .

WORKDIR "/src/src/Meetup.API"
RUN dotnet build "Meetup.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Meetup.API.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Meetup.API.dll"]