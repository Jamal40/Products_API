#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 5000

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
ARG BUILD_CONFIGURATION=Release
WORKDIR /src
COPY ["Products_API/Products_API.csproj", "Products_API/"]
RUN dotnet restore "./Products_API/./Products_API.csproj"
COPY . .
WORKDIR "/src/Products_API"
RUN dotnet build "./Products_API.csproj" -c $BUILD_CONFIGURATION -o /app/build

FROM build AS publish
ARG BUILD_CONFIGURATION=Release
RUN dotnet publish "./Products_API.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false

FROM base AS final
EXPOSE 8082
ENV ASPNETCORE_URLS=http://*:8082
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Products_API.dll"]
