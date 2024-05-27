#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["GymManager.Web/GymManager.Web.csproj", "GymManager.Web/"]
COPY ["GymManager.ApplicationServices/GymManager.ApplicationServices.csproj", "GymManager.ApplicationServices/"]
COPY ["GymManager.Core/GymManager.Core.csproj", "GymManager.Core/"]
COPY ["GymManager.DataAccess/GymManager.DataAccess.csproj", "GymManager.DataAccess/"]
RUN dotnet restore "./GymManager.Web/GymManager.Web.csproj"
COPY . .
WORKDIR "/src/GymManager.Web"
RUN dotnet build "./GymManager.Web.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./GymManager.Web.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GymManager.Web.dll"]