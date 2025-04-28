#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
USER app
WORKDIR /app
EXPOSE 8080
EXPOSE 8081

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Dustin.API/Dustin.API.csproj", "Dustin.API/"]
COPY ["Dustin.Application/Dustin.Application.csproj", "Dustin.Application/"]
COPY ["Dustin.Domain/Dustin.Domain.csproj", "Dustin.Domain/"]
COPY ["Dustin.Infrastructure/Dustin.Infrastructure.csproj", "Dustin.Infrastructure/"]
RUN dotnet restore "./Dustin.API/Dustin.API.csproj"
COPY . .
WORKDIR "/src/Dustin.API"
RUN dotnet build "./Dustin.API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Dustin.API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dustin.API.dll"]